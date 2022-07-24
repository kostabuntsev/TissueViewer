namespace TissueViewer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainerMainForm = new System.Windows.Forms.SplitContainer();
            this.leftTabControl = new System.Windows.Forms.TabControl();
            this.treeTabPage = new System.Windows.Forms.TabPage();
            this.openExternallyButton = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openExternallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.startupPathLabel = new System.Windows.Forms.Label();
            this.startupPathTextBox = new System.Windows.Forms.TextBox();
            this.restorePathCheckBox = new System.Windows.Forms.CheckBox();
            this.pathSettingsLabel = new System.Windows.Forms.Label();
            this.rightTabControl = new System.Windows.Forms.TabControl();
            this.imageViewerTabPage = new System.Windows.Forms.TabPage();
            this.imageViewerRictureBox = new System.Windows.Forms.PictureBox();
            this.textEditorTabPage = new System.Windows.Forms.TabPage();
            this.changeFontButton = new System.Windows.Forms.Button();
            this.textEditorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.browserTabPage = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.textEditorFontDialog = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainForm)).BeginInit();
            this.splitContainerMainForm.Panel1.SuspendLayout();
            this.splitContainerMainForm.Panel2.SuspendLayout();
            this.splitContainerMainForm.SuspendLayout();
            this.leftTabControl.SuspendLayout();
            this.treeTabPage.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.rightTabControl.SuspendLayout();
            this.imageViewerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewerRictureBox)).BeginInit();
            this.textEditorTabPage.SuspendLayout();
            this.browserTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMainForm
            // 
            resources.ApplyResources(this.splitContainerMainForm, "splitContainerMainForm");
            this.splitContainerMainForm.Name = "splitContainerMainForm";
            // 
            // splitContainerMainForm.Panel1
            // 
            resources.ApplyResources(this.splitContainerMainForm.Panel1, "splitContainerMainForm.Panel1");
            this.splitContainerMainForm.Panel1.Controls.Add(this.leftTabControl);
            // 
            // splitContainerMainForm.Panel2
            // 
            resources.ApplyResources(this.splitContainerMainForm.Panel2, "splitContainerMainForm.Panel2");
            this.splitContainerMainForm.Panel2.Controls.Add(this.rightTabControl);
            // 
            // leftTabControl
            // 
            this.leftTabControl.Controls.Add(this.treeTabPage);
            this.leftTabControl.Controls.Add(this.settingsTabPage);
            resources.ApplyResources(this.leftTabControl, "leftTabControl");
            this.leftTabControl.Name = "leftTabControl";
            this.leftTabControl.SelectedIndex = 0;
            // 
            // treeTabPage
            // 
            this.treeTabPage.Controls.Add(this.openExternallyButton);
            this.treeTabPage.Controls.Add(this.treeView);
            this.treeTabPage.Controls.Add(this.pathTextBox);
            this.treeTabPage.Controls.Add(this.browseButton);
            resources.ApplyResources(this.treeTabPage, "treeTabPage");
            this.treeTabPage.Name = "treeTabPage";
            this.treeTabPage.UseVisualStyleBackColor = true;
            // 
            // openExternallyButton
            // 
            resources.ApplyResources(this.openExternallyButton, "openExternallyButton");
            this.openExternallyButton.Name = "openExternallyButton";
            this.openExternallyButton.UseVisualStyleBackColor = true;
            this.openExternallyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView
            // 
            resources.ApplyResources(this.treeView, "treeView");
            this.treeView.CheckBoxes = true;
            this.treeView.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView.HideSelection = false;
            this.treeView.Name = "treeView";
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick_1);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExternallyToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // openExternallyToolStripMenuItem
            // 
            this.openExternallyToolStripMenuItem.Name = "openExternallyToolStripMenuItem";
            resources.ApplyResources(this.openExternallyToolStripMenuItem, "openExternallyToolStripMenuItem");
            this.openExternallyToolStripMenuItem.Click += new System.EventHandler(this.openExternallyToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            resources.ApplyResources(this.propertiesToolStripMenuItem, "propertiesToolStripMenuItem");
            // 
            // pathTextBox
            // 
            resources.ApplyResources(this.pathTextBox, "pathTextBox");
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.pathTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.pathTextBox.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // browseButton
            // 
            resources.ApplyResources(this.browseButton, "browseButton");
            this.browseButton.Name = "browseButton";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.startupPathLabel);
            this.settingsTabPage.Controls.Add(this.startupPathTextBox);
            this.settingsTabPage.Controls.Add(this.restorePathCheckBox);
            this.settingsTabPage.Controls.Add(this.pathSettingsLabel);
            resources.ApplyResources(this.settingsTabPage, "settingsTabPage");
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // startupPathLabel
            // 
            resources.ApplyResources(this.startupPathLabel, "startupPathLabel");
            this.startupPathLabel.Name = "startupPathLabel";
            // 
            // startupPathTextBox
            // 
            resources.ApplyResources(this.startupPathTextBox, "startupPathTextBox");
            this.startupPathTextBox.Name = "startupPathTextBox";
            this.startupPathTextBox.TextChanged += new System.EventHandler(this.startupPathTextBox_TextChanged);
            this.startupPathTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startupPathTextBox_KeyPress);
            // 
            // restorePathCheckBox
            // 
            resources.ApplyResources(this.restorePathCheckBox, "restorePathCheckBox");
            this.restorePathCheckBox.Checked = true;
            this.restorePathCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.restorePathCheckBox.Name = "restorePathCheckBox";
            this.restorePathCheckBox.UseVisualStyleBackColor = true;
            this.restorePathCheckBox.CheckedChanged += new System.EventHandler(this.rememberPathCheckBox_CheckedChanged);
            // 
            // pathSettingsLabel
            // 
            resources.ApplyResources(this.pathSettingsLabel, "pathSettingsLabel");
            this.pathSettingsLabel.Name = "pathSettingsLabel";
            // 
            // rightTabControl
            // 
            this.rightTabControl.Controls.Add(this.imageViewerTabPage);
            this.rightTabControl.Controls.Add(this.textEditorTabPage);
            this.rightTabControl.Controls.Add(this.browserTabPage);
            resources.ApplyResources(this.rightTabControl, "rightTabControl");
            this.rightTabControl.Multiline = true;
            this.rightTabControl.Name = "rightTabControl";
            this.rightTabControl.SelectedIndex = 0;
            // 
            // imageViewerTabPage
            // 
            this.imageViewerTabPage.Controls.Add(this.imageViewerRictureBox);
            resources.ApplyResources(this.imageViewerTabPage, "imageViewerTabPage");
            this.imageViewerTabPage.Name = "imageViewerTabPage";
            this.imageViewerTabPage.UseVisualStyleBackColor = true;
            // 
            // imageViewerRictureBox
            // 
            resources.ApplyResources(this.imageViewerRictureBox, "imageViewerRictureBox");
            this.imageViewerRictureBox.Name = "imageViewerRictureBox";
            this.imageViewerRictureBox.TabStop = false;
            // 
            // textEditorTabPage
            // 
            this.textEditorTabPage.Controls.Add(this.changeFontButton);
            this.textEditorTabPage.Controls.Add(this.textEditorRichTextBox);
            resources.ApplyResources(this.textEditorTabPage, "textEditorTabPage");
            this.textEditorTabPage.Name = "textEditorTabPage";
            this.textEditorTabPage.UseVisualStyleBackColor = true;
            // 
            // changeFontButton
            // 
            resources.ApplyResources(this.changeFontButton, "changeFontButton");
            this.changeFontButton.Name = "changeFontButton";
            this.changeFontButton.UseVisualStyleBackColor = true;
            this.changeFontButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // textEditorRichTextBox
            // 
            resources.ApplyResources(this.textEditorRichTextBox, "textEditorRichTextBox");
            this.textEditorRichTextBox.Name = "textEditorRichTextBox";
            // 
            // browserTabPage
            // 
            this.browserTabPage.Controls.Add(this.webBrowser);
            resources.ApplyResources(this.browserTabPage, "browserTabPage");
            this.browserTabPage.Name = "browserTabPage";
            this.browserTabPage.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            resources.ApplyResources(this.webBrowser, "webBrowser");
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerMainForm);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainerMainForm.Panel1.ResumeLayout(false);
            this.splitContainerMainForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainForm)).EndInit();
            this.splitContainerMainForm.ResumeLayout(false);
            this.leftTabControl.ResumeLayout(false);
            this.treeTabPage.ResumeLayout(false);
            this.treeTabPage.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.settingsTabPage.ResumeLayout(false);
            this.settingsTabPage.PerformLayout();
            this.rightTabControl.ResumeLayout(false);
            this.imageViewerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageViewerRictureBox)).EndInit();
            this.textEditorTabPage.ResumeLayout(false);
            this.browserTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox imageViewerRictureBox;
        private System.Windows.Forms.Button openExternallyButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TabControl rightTabControl;
        private System.Windows.Forms.TabPage imageViewerTabPage;
        private System.Windows.Forms.TabPage textEditorTabPage;
        private System.Windows.Forms.RichTextBox textEditorRichTextBox;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TabPage browserTabPage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.FontDialog textEditorFontDialog;
        private System.Windows.Forms.Button changeFontButton;
        private System.Windows.Forms.TabControl leftTabControl;
        private System.Windows.Forms.TabPage treeTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.SplitContainer splitContainerMainForm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openExternallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.CheckBox restorePathCheckBox;
        private System.Windows.Forms.Label pathSettingsLabel;
        private System.Windows.Forms.Label startupPathLabel;
        private System.Windows.Forms.TextBox startupPathTextBox;
    }
}

