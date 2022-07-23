namespace TissueViewer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageViewerRictureBox = new System.Windows.Forms.PictureBox();
            this.openExternallyButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.browseButton = new System.Windows.Forms.Button();
            this.rightTabControl = new System.Windows.Forms.TabControl();
            this.imageViewerTabPage = new System.Windows.Forms.TabPage();
            this.textEditorTabPage = new System.Windows.Forms.TabPage();
            this.changeFontButton = new System.Windows.Forms.Button();
            this.textEditorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.browserTabPage = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.textEditorFontDialog = new System.Windows.Forms.FontDialog();
            this.leftTabControl = new System.Windows.Forms.TabControl();
            this.treeTabPage = new System.Windows.Forms.TabPage();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewerRictureBox)).BeginInit();
            this.rightTabControl.SuspendLayout();
            this.imageViewerTabPage.SuspendLayout();
            this.textEditorTabPage.SuspendLayout();
            this.browserTabPage.SuspendLayout();
            this.leftTabControl.SuspendLayout();
            this.treeTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageViewerRictureBox
            // 
            resources.ApplyResources(this.imageViewerRictureBox, "imageViewerRictureBox");
            this.imageViewerRictureBox.Name = "imageViewerRictureBox";
            this.imageViewerRictureBox.TabStop = false;
            // 
            // openExternallyButton
            // 
            resources.ApplyResources(this.openExternallyButton, "openExternallyButton");
            this.openExternallyButton.Name = "openExternallyButton";
            this.openExternallyButton.UseVisualStyleBackColor = true;
            this.openExternallyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pathTextBox
            // 
            resources.ApplyResources(this.pathTextBox, "pathTextBox");
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.pathTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.pathTextBox.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // treeView
            // 
            resources.ApplyResources(this.treeView, "treeView");
            this.treeView.CheckBoxes = true;
            this.treeView.HideSelection = false;
            this.treeView.Name = "treeView";
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // browseButton
            // 
            resources.ApplyResources(this.browseButton, "browseButton");
            this.browseButton.Name = "browseButton";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // rightTabControl
            // 
            resources.ApplyResources(this.rightTabControl, "rightTabControl");
            this.rightTabControl.Controls.Add(this.imageViewerTabPage);
            this.rightTabControl.Controls.Add(this.textEditorTabPage);
            this.rightTabControl.Controls.Add(this.browserTabPage);
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
            // leftTabControl
            // 
            resources.ApplyResources(this.leftTabControl, "leftTabControl");
            this.leftTabControl.Controls.Add(this.treeTabPage);
            this.leftTabControl.Controls.Add(this.settingsTabPage);
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
            // settingsTabPage
            // 
            resources.ApplyResources(this.settingsTabPage, "settingsTabPage");
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.leftTabControl);
            this.Controls.Add(this.rightTabControl);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageViewerRictureBox)).EndInit();
            this.rightTabControl.ResumeLayout(false);
            this.imageViewerTabPage.ResumeLayout(false);
            this.textEditorTabPage.ResumeLayout(false);
            this.browserTabPage.ResumeLayout(false);
            this.leftTabControl.ResumeLayout(false);
            this.treeTabPage.ResumeLayout(false);
            this.treeTabPage.PerformLayout();
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
    }
}

