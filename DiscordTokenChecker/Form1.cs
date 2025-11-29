using Newtonsoft.Json.Linq;
using System.Reflection;
using System.Text;

namespace DiscordTokenChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ImageList ImgList = new ImageList();

            ImgList.ImageSize = new Size(32, 32);

            CheckedAccountsListView.SmallImageList = ImgList;

            __WindowState__.IsWindowRunning = true;
        }

        private void TokenFileEntry_Enter(object sender, EventArgs e)
        {
            TokenFileEntry.Text = "";
        }

        private void OutputFileNameEntry_Enter(object sender, EventArgs e)
        {
            OutputFileNameEntry.Text = "";
        }

        private void SaveAllValidsCkBx_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox[] OtherCheckBoxes = { SaveEMailVerifiedCkBx, SavePhoneVerifiedCkBx, SaveNitroBoostCkBx, SaveNitroBasicCkBx, SaveMFAEnabledCkBx };

            if (!SaveAllValidsCkBx.Checked)
            {
                Config.SaveAll = true;

                foreach (CheckBox cb in OtherCheckBoxes)
                {
                    cb.Enabled = true;
                }
            }
            else
            {
                Config.SaveAll = false;

                foreach (CheckBox cb in OtherCheckBoxes)
                {
                    cb.Checked = true;
                    cb.Enabled = false;
                }
            }
        }

        private async void StartCheckBtn_Click(object sender, EventArgs e)
        {
            CheckBox[] OtherCheckBoxes = { SaveEMailVerifiedCkBx, SavePhoneVerifiedCkBx, SaveNitroBoostCkBx, SaveNitroBasicCkBx, SaveMFAEnabledCkBx };

            if (TokenFileEntry.Text == "Enter the token file path or drop the file here" || string.IsNullOrEmpty(TokenFileEntry.Text))
            {
                MsgBox.Error("Missing informations", "Please provide the tokens file path");
                return;
            }
            else if (!File.Exists(TokenFileEntry.Text))
            {
                MsgBox.Error("Invalid tokens file", "The provided tokens file path doesn't exists.");
                return;
            }

            foreach (char _char in OutputFileNameEntry.Text.ToCharArray())
            {
                if (Path.GetInvalidFileNameChars().Contains(_char))
                {
                    MsgBox.Error("Invalid output file name", "The output file name contains invalid characters.");
                    return;
                }
            }

            if (File.Exists(OutputFileNameEntry.Text))
            {
                if (!MsgBox.AskYesNo("The output file already exists", $"{OutputFileNameEntry.Text} already exists and will be overwritten. Are you sure you want to continue ?", "Question"))
                {
                    return;
                }
            }

            if (!__WindowState__.IsChecking)
            {
                StartCheckBtn.Text = "Stop Checking";
                StartCheckBtn.ForeColor = Color.Red;

                OutputFileNameEntry.Enabled = false;

                __WindowState__.IsChecking = true;

                foreach (CheckBox cb in OtherCheckBoxes)
                {
                    cb.Enabled = false;
                }

                List<string> Checked = new List<string> { };

                CheckedAccountsListView.Items.Clear();
                CheckedAccountsListView.SmallImageList.Images.Clear();

                try
                {
                    foreach (string Token in File.ReadAllLines(TokenFileEntry.Text))
                    {
                        if (!__WindowState__.IsWindowRunning || !__WindowState__.IsChecking)
                            return;

                        string RawDatas = await Checker.GetDiscordTokenInfos(Token.Trim());

                        JObject Datas = JObject.Parse(RawDatas);

                        if (Datas["status"].ToString() == "notok")
                        {
                            continue;
                        }
                        else
                        {
                            if (Config.SaveAll)
                                Checked.Add(Token);
                            else if (Config.SaveEMailVerified || Config.SavePhoneVerified)
                                if (Datas["verified"].ToString().ToLower() == "true")
                                    Checked.Add(Token);
                                else
                                    continue;
                            else if (Config.SaveMFA)
                                if (Datas["mfa_enabled"].ToString().ToLower() == "true")
                                    Checked.Add(Token);
                                else
                                    continue;
                            else if (Config.SaveNitroBasic)
                                if (Datas["premium_type"].ToString() == "1")
                                    Checked.Add(Token);
                                else
                                    continue;
                            else if (Config.SaveNitroBoost)
                                if (Datas["premium_type"].ToString() == "2")
                                    Checked.Add(Token);
                                else
                                    continue;

                            ListViewItem item = new ListViewItem(Datas["global_name"].ToString());

                            Bitmap? Avatar = await Checker.GetUserAvatar(Datas["avatar"].ToString(), Datas["id"].ToString());

                            if (Avatar != null)
                                CheckedAccountsListView.SmallImageList.Images.Add(Datas["id"].ToString(), Avatar);
                            item.ImageKey = Datas["id"].ToString();

                            item.SubItems.Add(Datas["username"].ToString());
                            item.SubItems.Add(Datas["id"].ToString());
                            item.SubItems.Add(Datas["email"].ToString());

                            if (!string.IsNullOrEmpty(Datas["phone"].ToString()))
                                item.SubItems.Add(Datas["phone"].ToString());
                            else
                                item.SubItems.Add("--");

                            if (Datas["premium_type"].ToString() == "0")
                                item.SubItems.Add("--");
                            else if (Datas["premium_type"].ToString() == "1")
                                item.SubItems.Add("Nitro Basic");
                            else
                                item.SubItems.Add("Nitro Boost");

                            if (Datas["verified"].ToString().ToLower() == "true")
                                item.SubItems.Add("Yes");
                            else
                                item.SubItems.Add("No");

                            item.SubItems.Add(Token);

                            CheckedAccountsListView.Items.Add(item);
                        }
                    }

                    if (Checked.Count == 0)
                        MsgBox.Info("Verifications sucessful", "No valid token found");
                    else if (OutputFileNameEntry.Text.Trim() != "Output file name : leave blank to don't save" && !string.IsNullOrEmpty(OutputFileNameEntry.Text))
                    {
                        File.WriteAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), OutputFileNameEntry.Text), string.Join("\n", Checked));
                        MsgBox.Info("Verifications sucessful", $"{Checked.Count} tokens saved in {Path.Combine(Assembly.GetExecutingAssembly().Location, OutputFileNameEntry.Text)}");
                    }
                    else
                    {
                        MsgBox.Info("Verifications sucessful", "Total valid tokens : " + Checked.Count.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MsgBox.Error("An error occured", ex.Message);
                }

                StartCheckBtn.Text = "Start Checking";
                StartCheckBtn.ForeColor = Color.Black;

                SaveAllValidsCkBx.Checked = true;

                __WindowState__.IsChecking = false;

                OutputFileNameEntry.Enabled = true;

                foreach (CheckBox cb in OtherCheckBoxes)
                {
                    cb.Enabled = true;
                }
            }
            else
            {
                StartCheckBtn.Text = "Start Checking";
                StartCheckBtn.ForeColor = Color.Black;

                __WindowState__.IsChecking = false;

                OutputFileNameEntry.Enabled = true;

                foreach (CheckBox cb in OtherCheckBoxes)
                {
                    cb.Enabled = true;
                }
            }
        }

        private void BrowseTokenFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            fd.Title = "Choose the tokens file";
            fd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            DialogResult res = fd.ShowDialog();

            if (res.ToString() == "OK")
            {
                TokenFileEntry.Text = fd.FileName;
            }
        }

        private void SaveEMailVerifiedCkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveEMailVerifiedCkBx.Checked)
                Config.SaveEMailVerified = true;
            else
                Config.SaveEMailVerified = false;
        }

        private void SavePhoneVerifiedCkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (SavePhoneVerifiedCkBx.Checked)
                Config.SavePhoneVerified = true;
            else
                Config.SavePhoneVerified = false;
        }

        private void SaveNitroBoostCkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveNitroBoostCkBx.Checked)
                Config.SaveNitroBoost = true;
            else
                Config.SaveNitroBoost = false;
        }

        private void SaveNitroBasicCkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveNitroBasicCkBx.Checked)
                Config.SaveNitroBasic = true;
            else
                Config.SaveNitroBasic = false;
        }

        private void SaveMFAEnabledCkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveMFAEnabledCkBx.Checked)
                Config.SaveMFA = true;
            else
                Config.SaveMFA = false;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckedAccountsListView.SelectedItems.Count == 0)
                return;

            ListViewItem item = CheckedAccountsListView.SelectedItems[0];

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"<============[ DATAS FOR {item.SubItems[0].Text}]============>");
            sb.AppendLine("");
            sb.AppendLine($"GLOBAL NAME  : " + item.SubItems[0].Text);
            sb.AppendLine($"USERNAME     : " + item.SubItems[1].Text);
            sb.AppendLine($"USER ID      : " + item.SubItems[2].Text);
            sb.AppendLine($"MAIL ADDRESS : " + item.SubItems[3].Text);
            sb.AppendLine($"PHONE NUMBER : " + item.SubItems[4].Text);
            sb.AppendLine($"SUBSCRIPTION : " + item.SubItems[5].Text);
            sb.AppendLine($"VERIFIED     : " + item.SubItems[6].Text);
            sb.AppendLine($"TOKEN        : " + item.SubItems[7].Text);
            sb.AppendLine("<=============================================================>");

            Clipboard.SetText(sb.ToString());
        }

        private void CheckedAccountsListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                CopyInfosCtxMenu.Show(Cursor.Position);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            __WindowState__.IsChecking = false;
            __WindowState__.IsWindowRunning = false;
        }
    }
}
