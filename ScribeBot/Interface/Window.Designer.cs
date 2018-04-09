﻿using System.Drawing;
using System.Windows.Forms;

namespace ScribeBot.Interface
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.consolePanel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.consoleInput = new System.Windows.Forms.TextBox();
            this.consoleRun = new System.Windows.Forms.Button();
            this.consoleContainer = new System.Windows.Forms.Panel();
            this.consoleOutput = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.asyncStringCheck = new System.Windows.Forms.CheckBox();
            this.consoleClearButton = new System.Windows.Forms.Button();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.optionsPanel = new System.Windows.Forms.TabControl();
            this.scriptsPage = new System.Windows.Forms.TabPage();
            this.installedPackagesPanel = new System.Windows.Forms.Panel();
            this.installedPackagesList = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.asyncCheckbox = new System.Windows.Forms.CheckBox();
            this.logCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.scriptStop = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.workshopFetchButton = new System.Windows.Forms.Button();
            this.browserPackagePanel = new System.Windows.Forms.Panel();
            this.browserPackageList = new System.Windows.Forms.TableLayoutPanel();
            this.noticeTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.consolePanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.consoleContainer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.layoutPanel.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.scriptsPage.SuspendLayout();
            this.installedPackagesPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.browserPackagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // consolePanel
            // 
            this.consolePanel.Controls.Add(this.tableLayoutPanel3);
            this.consolePanel.Controls.Add(this.consoleContainer);
            this.consolePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consolePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consolePanel.Location = new System.Drawing.Point(3, 3);
            this.consolePanel.Name = "consolePanel";
            this.consolePanel.Padding = new System.Windows.Forms.Padding(5);
            this.consolePanel.Size = new System.Drawing.Size(486, 556);
            this.consolePanel.TabIndex = 0;
            this.consolePanel.TabStop = false;
            this.consolePanel.Text = "Console";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel3.Controls.Add(this.consoleInput, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.consoleRun, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(11, 525);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(465, 21);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // consoleInput
            // 
            this.consoleInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleInput.Location = new System.Drawing.Point(0, 0);
            this.consoleInput.Margin = new System.Windows.Forms.Padding(0);
            this.consoleInput.Name = "consoleInput";
            this.consoleInput.Size = new System.Drawing.Size(335, 20);
            this.consoleInput.TabIndex = 1;
            this.consoleInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.consoleInput_KeyPress);
            // 
            // consoleRun
            // 
            this.consoleRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleRun.Location = new System.Drawing.Point(335, 0);
            this.consoleRun.Margin = new System.Windows.Forms.Padding(0);
            this.consoleRun.Name = "consoleRun";
            this.consoleRun.Size = new System.Drawing.Size(130, 21);
            this.consoleRun.TabIndex = 2;
            this.consoleRun.Text = "Execute";
            this.noticeTooltip.SetToolTip(this.consoleRun, "Executing a string while other script is running will stop the script.");
            this.consoleRun.UseVisualStyleBackColor = true;
            this.consoleRun.Click += new System.EventHandler(this.consoleRun_Click);
            // 
            // consoleContainer
            // 
            this.consoleContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleContainer.Controls.Add(this.consoleOutput);
            this.consoleContainer.Controls.Add(this.tableLayoutPanel2);
            this.consoleContainer.Location = new System.Drawing.Point(10, 24);
            this.consoleContainer.Margin = new System.Windows.Forms.Padding(5);
            this.consoleContainer.Name = "consoleContainer";
            this.consoleContainer.Size = new System.Drawing.Size(466, 485);
            this.consoleContainer.TabIndex = 3;
            // 
            // consoleOutput
            // 
            this.consoleOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.consoleOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleOutput.DetectUrls = false;
            this.consoleOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.consoleOutput.ForeColor = System.Drawing.Color.Black;
            this.consoleOutput.Location = new System.Drawing.Point(0, 0);
            this.consoleOutput.Margin = new System.Windows.Forms.Padding(0);
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.ReadOnly = true;
            this.consoleOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.consoleOutput.Size = new System.Drawing.Size(464, 450);
            this.consoleOutput.TabIndex = 0;
            this.consoleOutput.Text = "";
            this.consoleOutput.TextChanged += new System.EventHandler(this.consoleOutput_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.asyncStringCheck, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.consoleClearButton, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 450);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(464, 33);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // asyncStringCheck
            // 
            this.asyncStringCheck.AutoSize = true;
            this.asyncStringCheck.BackColor = System.Drawing.Color.Transparent;
            this.asyncStringCheck.Checked = true;
            this.asyncStringCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.asyncStringCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.asyncStringCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asyncStringCheck.ForeColor = System.Drawing.SystemColors.InfoText;
            this.asyncStringCheck.Location = new System.Drawing.Point(5, 5);
            this.asyncStringCheck.Margin = new System.Windows.Forms.Padding(5);
            this.asyncStringCheck.Name = "asyncStringCheck";
            this.asyncStringCheck.Size = new System.Drawing.Size(106, 23);
            this.asyncStringCheck.TabIndex = 0;
            this.asyncStringCheck.Text = "Async";
            this.noticeTooltip.SetToolTip(this.asyncStringCheck, "Execute string on a separate thread to prevent user interface from freezing durin" +
        "g the execution.\r\nKeep in mind that this might disable syntax debugger.");
            this.asyncStringCheck.UseVisualStyleBackColor = false;
            // 
            // consoleClearButton
            // 
            this.consoleClearButton.BackColor = System.Drawing.Color.Transparent;
            this.consoleClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleClearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.consoleClearButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.consoleClearButton.Location = new System.Drawing.Point(353, 5);
            this.consoleClearButton.Margin = new System.Windows.Forms.Padding(5);
            this.consoleClearButton.Name = "consoleClearButton";
            this.consoleClearButton.Size = new System.Drawing.Size(106, 23);
            this.consoleClearButton.TabIndex = 1;
            this.consoleClearButton.Text = "Clear";
            this.consoleClearButton.UseVisualStyleBackColor = false;
            this.consoleClearButton.Click += new System.EventHandler(this.consoleClearButton_Click);
            // 
            // layoutPanel
            // 
            this.layoutPanel.ColumnCount = 2;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPanel.Controls.Add(this.consolePanel, 0, 0);
            this.layoutPanel.Controls.Add(this.optionsPanel, 1, 0);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 1;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.Size = new System.Drawing.Size(784, 562);
            this.layoutPanel.TabIndex = 1;
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.scriptsPage);
            this.optionsPanel.Controls.Add(this.tabPage1);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsPanel.Location = new System.Drawing.Point(497, 5);
            this.optionsPanel.Margin = new System.Windows.Forms.Padding(5);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.SelectedIndex = 0;
            this.optionsPanel.Size = new System.Drawing.Size(282, 552);
            this.optionsPanel.TabIndex = 1;
            // 
            // scriptsPage
            // 
            this.scriptsPage.Controls.Add(this.installedPackagesPanel);
            this.scriptsPage.Controls.Add(this.tableLayoutPanel5);
            this.scriptsPage.Controls.Add(this.tableLayoutPanel1);
            this.scriptsPage.Location = new System.Drawing.Point(4, 22);
            this.scriptsPage.Margin = new System.Windows.Forms.Padding(0);
            this.scriptsPage.Name = "scriptsPage";
            this.scriptsPage.Padding = new System.Windows.Forms.Padding(5);
            this.scriptsPage.Size = new System.Drawing.Size(274, 526);
            this.scriptsPage.TabIndex = 0;
            this.scriptsPage.Text = "Packages";
            this.scriptsPage.UseVisualStyleBackColor = true;
            // 
            // installedPackagesPanel
            // 
            this.installedPackagesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.installedPackagesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.installedPackagesPanel.Controls.Add(this.installedPackagesList);
            this.installedPackagesPanel.Location = new System.Drawing.Point(10, 10);
            this.installedPackagesPanel.Margin = new System.Windows.Forms.Padding(5);
            this.installedPackagesPanel.Name = "installedPackagesPanel";
            this.installedPackagesPanel.Size = new System.Drawing.Size(254, 444);
            this.installedPackagesPanel.TabIndex = 7;
            // 
            // installedPackagesList
            // 
            this.installedPackagesList.AutoScroll = true;
            this.installedPackagesList.AutoSize = true;
            this.installedPackagesList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.installedPackagesList.BackColor = System.Drawing.Color.Transparent;
            this.installedPackagesList.ColumnCount = 1;
            this.installedPackagesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.installedPackagesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installedPackagesList.Location = new System.Drawing.Point(0, 0);
            this.installedPackagesList.Margin = new System.Windows.Forms.Padding(0);
            this.installedPackagesList.Name = "installedPackagesList";
            this.installedPackagesList.RowCount = 1;
            this.installedPackagesList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.installedPackagesList.Size = new System.Drawing.Size(252, 442);
            this.installedPackagesList.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.asyncCheckbox, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.logCheckBox, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(10, 464);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(254, 21);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // asyncCheckbox
            // 
            this.asyncCheckbox.AutoSize = true;
            this.asyncCheckbox.Checked = true;
            this.asyncCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.asyncCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.asyncCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asyncCheckbox.Location = new System.Drawing.Point(0, 0);
            this.asyncCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.asyncCheckbox.Name = "asyncCheckbox";
            this.asyncCheckbox.Size = new System.Drawing.Size(127, 21);
            this.asyncCheckbox.TabIndex = 2;
            this.asyncCheckbox.Text = "Async";
            this.noticeTooltip.SetToolTip(this.asyncCheckbox, "Execute script on a separate thread to prevent user interface from freezing durin" +
        "g script\'s routine.\r\nKeep in mind that this might disable syntax debugger.");
            this.asyncCheckbox.UseVisualStyleBackColor = true;
            // 
            // logCheckBox
            // 
            this.logCheckBox.AutoSize = true;
            this.logCheckBox.Checked = true;
            this.logCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.logCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logCheckBox.Location = new System.Drawing.Point(127, 0);
            this.logCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.logCheckBox.Name = "logCheckBox";
            this.logCheckBox.Size = new System.Drawing.Size(127, 21);
            this.logCheckBox.TabIndex = 3;
            this.logCheckBox.Text = "Log";
            this.noticeTooltip.SetToolTip(this.logCheckBox, "Whether or not program should dump log into a date-signed file.");
            this.logCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.scriptStop, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 495);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 21);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // scriptStop
            // 
            this.scriptStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptStop.Location = new System.Drawing.Point(0, 0);
            this.scriptStop.Margin = new System.Windows.Forms.Padding(0);
            this.scriptStop.Name = "scriptStop";
            this.scriptStop.Size = new System.Drawing.Size(254, 21);
            this.scriptStop.TabIndex = 2;
            this.scriptStop.Text = "Stop";
            this.noticeTooltip.SetToolTip(this.scriptStop, "This will force currently running script to stop");
            this.scriptStop.UseVisualStyleBackColor = true;
            this.scriptStop.Click += new System.EventHandler(this.scriptStop_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(274, 526);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Workshop";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.browserPackagePanel, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(264, 516);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.workshopFetchButton, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(5, 490);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(254, 21);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // workshopFetchButton
            // 
            this.workshopFetchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workshopFetchButton.Location = new System.Drawing.Point(0, 0);
            this.workshopFetchButton.Margin = new System.Windows.Forms.Padding(0);
            this.workshopFetchButton.Name = "workshopFetchButton";
            this.workshopFetchButton.Size = new System.Drawing.Size(254, 21);
            this.workshopFetchButton.TabIndex = 2;
            this.workshopFetchButton.Text = "Fetch";
            this.workshopFetchButton.UseVisualStyleBackColor = true;
            this.workshopFetchButton.Click += new System.EventHandler(this.workshopFetchButton_Click);
            // 
            // browserPackagePanel
            // 
            this.browserPackagePanel.BackColor = System.Drawing.SystemColors.Control;
            this.browserPackagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.browserPackagePanel.Controls.Add(this.browserPackageList);
            this.browserPackagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserPackagePanel.Location = new System.Drawing.Point(5, 5);
            this.browserPackagePanel.Margin = new System.Windows.Forms.Padding(5);
            this.browserPackagePanel.Name = "browserPackagePanel";
            this.browserPackagePanel.Size = new System.Drawing.Size(254, 475);
            this.browserPackagePanel.TabIndex = 2;
            // 
            // browserPackageList
            // 
            this.browserPackageList.AutoScroll = true;
            this.browserPackageList.AutoSize = true;
            this.browserPackageList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browserPackageList.BackColor = System.Drawing.Color.Transparent;
            this.browserPackageList.ColumnCount = 1;
            this.browserPackageList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.browserPackageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserPackageList.Location = new System.Drawing.Point(0, 0);
            this.browserPackageList.Margin = new System.Windows.Forms.Padding(0);
            this.browserPackageList.Name = "browserPackageList";
            this.browserPackageList.RowCount = 1;
            this.browserPackageList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.browserPackageList.Size = new System.Drawing.Size(252, 473);
            this.browserPackageList.TabIndex = 1;
            // 
            // noticeTooltip
            // 
            this.noticeTooltip.AutoPopDelay = 5000;
            this.noticeTooltip.InitialDelay = 200;
            this.noticeTooltip.ReshowDelay = 100;
            this.noticeTooltip.ShowAlways = true;
            this.noticeTooltip.ToolTipTitle = "Notice";
            this.noticeTooltip.UseAnimation = false;
            this.noticeTooltip.UseFading = false;
            // 
            // Window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.layoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScribeBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_FormClosing);
            this.consolePanel.ResumeLayout(false);
            this.consolePanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.consoleContainer.ResumeLayout(false);
            this.consoleContainer.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.layoutPanel.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.scriptsPage.ResumeLayout(false);
            this.installedPackagesPanel.ResumeLayout(false);
            this.installedPackagesPanel.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.browserPackagePanel.ResumeLayout(false);
            this.browserPackagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox consolePanel;
        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.TabControl optionsPanel;
        private System.Windows.Forms.TabPage scriptsPage;
        private RichTextBox consoleOutput;
        private CheckBox asyncCheckbox;
        private ToolTip noticeTooltip;
        private TextBox consoleInput;
        private Button consoleRun;
        private Panel consoleContainer;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckBox asyncStringCheck;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private CheckBox logCheckBox;
        private Button consoleClearButton;
        private TabPage tabPage1;
        private Button scriptStop;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Button workshopFetchButton;
        private Panel installedPackagesPanel;
        private TableLayoutPanel installedPackagesList;
        private Panel browserPackagePanel;
        private TableLayoutPanel browserPackageList;

        public RichTextBox ConsoleOutput { get => consoleOutput; set => consoleOutput = value; }
        public CheckBox AsyncCheckbox { get => asyncCheckbox; set => asyncCheckbox = value; }
        public TextBox ConsoleInput { get => consoleInput; set => consoleInput = value; }
        public Button ConsoleRun { get => consoleRun; set => consoleRun = value; }
        public Button ScriptStop { get => scriptStop; set => scriptStop = value; }
        public CheckBox AsyncStringCheck { get => asyncStringCheck; set => asyncStringCheck = value; }
        public CheckBox LogCheckBox { get => logCheckBox; set => logCheckBox = value; }
        public Button ConsoleClearButton { get => consoleClearButton; set => consoleClearButton = value; }
        public Button WorkshopFetchButton { get => workshopFetchButton; set => workshopFetchButton = value; }
        public TableLayoutPanel InstalledPackagesList { get => installedPackagesList; set => installedPackagesList = value; }
        public TableLayoutPanel BrowserPackageList { get => browserPackageList; set => browserPackageList = value; }
    }
}