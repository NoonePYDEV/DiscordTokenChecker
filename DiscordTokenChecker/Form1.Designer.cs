namespace DiscordTokenChecker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            CheckedAccountsListView = new ListView();
            TokenGlobalNameCol = new ColumnHeader();
            TokenUsernameCol = new ColumnHeader();
            TokenIdCol = new ColumnHeader();
            TokenEMailCol = new ColumnHeader();
            TokenPhoneCol = new ColumnHeader();
            TokenSubcribeCol = new ColumnHeader();
            TokenVerifiedCol = new ColumnHeader();
            TokenCol = new ColumnHeader();
            groupBox1 = new GroupBox();
            SaveMFAEnabledCkBx = new CheckBox();
            SaveNitroBasicCkBx = new CheckBox();
            SaveNitroBoostCkBx = new CheckBox();
            SavePhoneVerifiedCkBx = new CheckBox();
            SaveEMailVerifiedCkBx = new CheckBox();
            SaveAllValidsCkBx = new CheckBox();
            groupBox2 = new GroupBox();
            BrowseTokenFileBtn = new Button();
            TokenFileEntry = new TextBox();
            StartCheckBtn = new Button();
            groupBox3 = new GroupBox();
            label1 = new Label();
            OutputFileNameEntry = new TextBox();
            CopyInfosCtxMenu = new ContextMenuStrip(components);
            copyToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            CopyInfosCtxMenu.SuspendLayout();
            SuspendLayout();
            // 
            // CheckedAccountsListView
            // 
            CheckedAccountsListView.Columns.AddRange(new ColumnHeader[] { TokenGlobalNameCol, TokenUsernameCol, TokenIdCol, TokenEMailCol, TokenPhoneCol, TokenSubcribeCol, TokenVerifiedCol, TokenCol });
            CheckedAccountsListView.FullRowSelect = true;
            CheckedAccountsListView.GridLines = true;
            CheckedAccountsListView.Location = new Point(12, 178);
            CheckedAccountsListView.Name = "CheckedAccountsListView";
            CheckedAccountsListView.Size = new Size(776, 260);
            CheckedAccountsListView.TabIndex = 0;
            CheckedAccountsListView.UseCompatibleStateImageBehavior = false;
            CheckedAccountsListView.View = View.Details;
            CheckedAccountsListView.MouseClick += CheckedAccountsListView_MouseClick;
            // 
            // TokenGlobalNameCol
            // 
            TokenGlobalNameCol.Text = "Global Name";
            TokenGlobalNameCol.Width = 120;
            // 
            // TokenUsernameCol
            // 
            TokenUsernameCol.Text = "Username";
            TokenUsernameCol.Width = 100;
            // 
            // TokenIdCol
            // 
            TokenIdCol.Text = "ID";
            TokenIdCol.Width = 80;
            // 
            // TokenEMailCol
            // 
            TokenEMailCol.Text = "EMail Address";
            TokenEMailCol.Width = 100;
            // 
            // TokenPhoneCol
            // 
            TokenPhoneCol.Text = "PhoneNumber";
            TokenPhoneCol.Width = 100;
            // 
            // TokenSubcribeCol
            // 
            TokenSubcribeCol.Text = "Subscription";
            TokenSubcribeCol.Width = 100;
            // 
            // TokenVerifiedCol
            // 
            TokenVerifiedCol.Text = "Verified";
            TokenVerifiedCol.Width = 80;
            // 
            // TokenCol
            // 
            TokenCol.Text = "Token";
            TokenCol.Width = 95;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SaveMFAEnabledCkBx);
            groupBox1.Controls.Add(SaveNitroBasicCkBx);
            groupBox1.Controls.Add(SaveNitroBoostCkBx);
            groupBox1.Controls.Add(SavePhoneVerifiedCkBx);
            groupBox1.Controls.Add(SaveEMailVerifiedCkBx);
            groupBox1.Controls.Add(SaveAllValidsCkBx);
            groupBox1.Location = new Point(361, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 112);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // SaveMFAEnabledCkBx
            // 
            SaveMFAEnabledCkBx.AutoSize = true;
            SaveMFAEnabledCkBx.Checked = true;
            SaveMFAEnabledCkBx.CheckState = CheckState.Checked;
            SaveMFAEnabledCkBx.Enabled = false;
            SaveMFAEnabledCkBx.Location = new Point(243, 76);
            SaveMFAEnabledCkBx.Name = "SaveMFAEnabledCkBx";
            SaveMFAEnabledCkBx.Size = new Size(173, 19);
            SaveMFAEnabledCkBx.TabIndex = 5;
            SaveMFAEnabledCkBx.Text = "Save MFA enabled accounts";
            SaveMFAEnabledCkBx.UseVisualStyleBackColor = true;
            SaveMFAEnabledCkBx.CheckedChanged += SaveMFAEnabledCkBx_CheckedChanged;
            // 
            // SaveNitroBasicCkBx
            // 
            SaveNitroBasicCkBx.AutoSize = true;
            SaveNitroBasicCkBx.Checked = true;
            SaveNitroBasicCkBx.CheckState = CheckState.Checked;
            SaveNitroBasicCkBx.Enabled = false;
            SaveNitroBasicCkBx.Location = new Point(243, 51);
            SaveNitroBasicCkBx.Name = "SaveNitroBasicCkBx";
            SaveNitroBasicCkBx.Size = new Size(161, 19);
            SaveNitroBasicCkBx.TabIndex = 4;
            SaveNitroBasicCkBx.Text = "Save Nitro Basic accounts";
            SaveNitroBasicCkBx.UseVisualStyleBackColor = true;
            SaveNitroBasicCkBx.CheckedChanged += SaveNitroBasicCkBx_CheckedChanged;
            // 
            // SaveNitroBoostCkBx
            // 
            SaveNitroBoostCkBx.AutoSize = true;
            SaveNitroBoostCkBx.Checked = true;
            SaveNitroBoostCkBx.CheckState = CheckState.Checked;
            SaveNitroBoostCkBx.Enabled = false;
            SaveNitroBoostCkBx.Location = new Point(243, 24);
            SaveNitroBoostCkBx.Name = "SaveNitroBoostCkBx";
            SaveNitroBoostCkBx.Size = new Size(164, 19);
            SaveNitroBoostCkBx.TabIndex = 3;
            SaveNitroBoostCkBx.Text = "Save Nitro Boost accounts";
            SaveNitroBoostCkBx.UseVisualStyleBackColor = true;
            SaveNitroBoostCkBx.CheckedChanged += SaveNitroBoostCkBx_CheckedChanged;
            // 
            // SavePhoneVerifiedCkBx
            // 
            SavePhoneVerifiedCkBx.AutoSize = true;
            SavePhoneVerifiedCkBx.Checked = true;
            SavePhoneVerifiedCkBx.CheckState = CheckState.Checked;
            SavePhoneVerifiedCkBx.Enabled = false;
            SavePhoneVerifiedCkBx.Location = new Point(15, 76);
            SavePhoneVerifiedCkBx.Name = "SavePhoneVerifiedCkBx";
            SavePhoneVerifiedCkBx.Size = new Size(180, 19);
            SavePhoneVerifiedCkBx.TabIndex = 2;
            SavePhoneVerifiedCkBx.Text = "Save phone verified accounts";
            SavePhoneVerifiedCkBx.UseVisualStyleBackColor = true;
            SavePhoneVerifiedCkBx.CheckedChanged += SavePhoneVerifiedCkBx_CheckedChanged;
            // 
            // SaveEMailVerifiedCkBx
            // 
            SaveEMailVerifiedCkBx.AutoSize = true;
            SaveEMailVerifiedCkBx.Checked = true;
            SaveEMailVerifiedCkBx.CheckState = CheckState.Checked;
            SaveEMailVerifiedCkBx.Enabled = false;
            SaveEMailVerifiedCkBx.Location = new Point(15, 51);
            SaveEMailVerifiedCkBx.Name = "SaveEMailVerifiedCkBx";
            SaveEMailVerifiedCkBx.Size = new Size(175, 19);
            SaveEMailVerifiedCkBx.TabIndex = 1;
            SaveEMailVerifiedCkBx.Text = "Save email verified accounts";
            SaveEMailVerifiedCkBx.UseVisualStyleBackColor = true;
            SaveEMailVerifiedCkBx.CheckedChanged += SaveEMailVerifiedCkBx_CheckedChanged;
            // 
            // SaveAllValidsCkBx
            // 
            SaveAllValidsCkBx.AutoSize = true;
            SaveAllValidsCkBx.Checked = true;
            SaveAllValidsCkBx.CheckState = CheckState.Checked;
            SaveAllValidsCkBx.Location = new Point(15, 26);
            SaveAllValidsCkBx.Name = "SaveAllValidsCkBx";
            SaveAllValidsCkBx.Size = new Size(144, 19);
            SaveAllValidsCkBx.TabIndex = 0;
            SaveAllValidsCkBx.Text = "Save all valid accounts";
            SaveAllValidsCkBx.UseVisualStyleBackColor = true;
            SaveAllValidsCkBx.CheckedChanged += SaveAllValidsCkBx_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BrowseTokenFileBtn);
            groupBox2.Controls.Add(TokenFileEntry);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(343, 84);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Input";
            // 
            // BrowseTokenFileBtn
            // 
            BrowseTokenFileBtn.Location = new Point(6, 51);
            BrowseTokenFileBtn.Name = "BrowseTokenFileBtn";
            BrowseTokenFileBtn.Size = new Size(331, 23);
            BrowseTokenFileBtn.TabIndex = 1;
            BrowseTokenFileBtn.Text = "Browse in the file explorer";
            BrowseTokenFileBtn.UseVisualStyleBackColor = true;
            BrowseTokenFileBtn.Click += BrowseTokenFileBtn_Click;
            // 
            // TokenFileEntry
            // 
            TokenFileEntry.AllowDrop = true;
            TokenFileEntry.Location = new Point(6, 22);
            TokenFileEntry.Name = "TokenFileEntry";
            TokenFileEntry.Size = new Size(331, 23);
            TokenFileEntry.TabIndex = 0;
            TokenFileEntry.Text = "Enter the token file path or drop the file here";
            TokenFileEntry.Enter += TokenFileEntry_Enter;
            // 
            // StartCheckBtn
            // 
            StartCheckBtn.Location = new Point(361, 130);
            StartCheckBtn.Name = "StartCheckBtn";
            StartCheckBtn.Size = new Size(427, 42);
            StartCheckBtn.TabIndex = 3;
            StartCheckBtn.Text = "Start Checking";
            StartCheckBtn.UseVisualStyleBackColor = true;
            StartCheckBtn.Click += StartCheckBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(OutputFileNameEntry);
            groupBox3.Location = new Point(12, 102);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(343, 70);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Output";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F);
            label1.Location = new Point(8, 19);
            label1.Name = "label1";
            label1.Size = new Size(328, 13);
            label1.TabIndex = 1;
            label1.Text = "The file where valid tokens are saved. Leave blank = don't save";
            // 
            // OutputFileNameEntry
            // 
            OutputFileNameEntry.Location = new Point(6, 39);
            OutputFileNameEntry.Name = "OutputFileNameEntry";
            OutputFileNameEntry.Size = new Size(331, 23);
            OutputFileNameEntry.TabIndex = 0;
            OutputFileNameEntry.Enter += OutputFileNameEntry_Enter;
            // 
            // CopyInfosCtxMenu
            // 
            CopyInfosCtxMenu.Items.AddRange(new ToolStripItem[] { copyToolStripMenuItem });
            CopyInfosCtxMenu.Name = "contextMenuStrip1";
            CopyInfosCtxMenu.Size = new Size(135, 26);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(134, 22);
            copyToolStripMenuItem.Text = "Copy Datas";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(StartCheckBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(CheckedAccountsListView);
            Name = "Form1";
            Text = "Discord Tokens Checker ";
            FormClosing += Form1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            CopyInfosCtxMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView CheckedAccountsListView;
        private ColumnHeader TokenPfpCol;
        private ColumnHeader TokenGlobalNameCol;
        private ColumnHeader TokenUsernameCol;
        private ColumnHeader TokenIdCol;
        private ColumnHeader TokenEMailCol;
        private ColumnHeader TokenPhoneCol;
        private ColumnHeader TokenSubcribeCol;
        private ColumnHeader TokenVerifiedCol;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BrowseTokenFileBtn;
        private TextBox TokenFileEntry;
        private Button StartCheckBtn;
        private GroupBox groupBox3;
        private TextBox OutputFileNameEntry;
        private CheckBox SaveNitroBoostCkBx;
        private CheckBox SavePhoneVerifiedCkBx;
        private CheckBox SaveEMailVerifiedCkBx;
        private CheckBox SaveAllValidsCkBx;
        private CheckBox SaveMFAEnabledCkBx;
        private CheckBox SaveNitroBasicCkBx;
        private ColumnHeader TokenCol;
        private Label label1;
        private ContextMenuStrip CopyInfosCtxMenu;
        private ToolStripMenuItem copyToolStripMenuItem;
    }
}
