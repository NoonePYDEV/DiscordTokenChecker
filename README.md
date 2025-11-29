# Discord Token Checker GUI

A simple Windows Forms application for checking and filtering Discord tokens locally. This tool allows you to validate tokens, retrieve user data, and optionally save filtered results. Built with C# and Newtonsoft.Json for JSON parsing.

---

## Table of Contents

1. [Overview](#overview)
2. [Features](#features)
3. [Requirements](#requirements)
4. [Setup](#setup)
5. [Usage](#usage)
6. [Configuration](#configuration)
7. [Screenshot](#screenshot)

---

## Overview

This application is designed to help users validate and inspect Discord tokens. It loads a list of tokens from a text file, checks them asynchronously, and displays the results in a clean interface. Users can filter based on email verification, phone verification, Nitro subscription type, or MFA enabled status.

---

## Features

* Validate Discord tokens in bulk.
* Display token-associated data: username, global name, email, phone number, Nitro subscription, and MFA status.
* Filter results by verified email, phone, Nitro type, or MFA.
* Save valid tokens to a file.
* Copy user info in a structured format directly from the UI.
* Lightweight and straightforward Windows Forms interface.

---

## Requirements

* Windows 10 or newer
* .NET Framework 4.8 or later
* Newtonsoft.Json library

---

## Setup

1. Clone or download the repository.
2. Open the solution in Visual Studio.
3. Restore NuGet packages (especially `Newtonsoft.Json`) or run the file `Quick Setup.bat`.
4. Build the project.

---

## Usage

1. Open the built executable.
2. Choose a text file containing tokens (one token per line).
3. Optionally configure filters:

   * Save all valid tokens
   * Save email-verified tokens
   * Save phone-verified tokens
   * Save Nitro Basic or Boost tokens
   * Save MFA-enabled tokens

4. Enter an output file name if you want to save results.
5. Click **Start Checking** to begin.
6. Right-click a user in the results to copy detailed info.

---

## Configuration

The following checkboxes control what kind of tokens get saved:

* **Save All Valids**: Overrides other filters.
* **Save Email Verified**: Only saves tokens with verified emails.
* **Save Phone Verified**: Only saves tokens with verified phone numbers.
* **Save Nitro Basic / Boost**: Only saves tokens with specified Nitro subscriptions.
* **Save MFA Enabled**: Only saves tokens where MFA is enabled.

---

## Screenshot

<img width="1237" height="774" alt="Capture d&#39;écran 2025-11-29 225200" src="https://github.com/user-attachments/assets/c8f31f55-dc6b-4aa4-bdcf-886facef8da4" />

---

This project is intended for educational purposes. 
