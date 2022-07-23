﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace TissueViewer
{
    public partial class MainForm : Form
    {
        public string path = ConfigurationHelper.GetAppSetting("rootPath");

        public bool isDirectory(TreeNode treeNode)
        {
            return (treeNode.Tag as TreeNodeMetadata).FSItem == FSItem.Directory;
        }

        public MainForm()
        {
            InitializeComponent();

            //load Folder structure
            imageViewerRictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            //webBrowser1.Size = webBrowser1.Document.Body.ScrollRectangle.Size;
            ListDirectory(treeView, path);
            pathTextBox.Text = path;
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            if (String.IsNullOrWhiteSpace(path)) return;

            treeView.Nodes.Clear();

            var rootDrectoryInfo = new DirectoryInfo(path);

            treeView.Nodes.Add(CreateDirectoryNode(rootDrectoryInfo));
        }

        

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            directoryNode.Tag = new TreeNodeMetadata(FSItem.Directory, directoryInfo.FullName, null);
            //directoryNode.Tag 
            foreach (var directory in directoryInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }

            foreach (var file in directoryInfo.GetFiles())
            {
                var fileNode = new TreeNode(file.Name);
                fileNode.Tag = new TreeNodeMetadata(FSItem.File, file.FullName, file.Extension);
                directoryNode.Nodes.Add(fileNode);
            }

            return directoryNode;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!isDirectory(treeView.SelectedNode))
            {
                TreeNode selectedNode = treeView.SelectedNode;
                var metadata = (selectedNode.Tag as TreeNodeMetadata);
                string filePath = metadata.FullName;
                Uri uri = new Uri(filePath);
                webBrowser.Url = uri;
                imageViewerRictureBox.ImageLocation = filePath;
                textEditorRichTextBox.Text = File.ReadAllText(filePath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isDirectory(treeView.SelectedNode))
            {
                System.Diagnostics.Process.Start((treeView.SelectedNode.Tag as TreeNodeMetadata).FullName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            path = folderBrowserDialog.SelectedPath;
            pathTextBox.Text = path;
            ListDirectory(treeView, path);
            SaveRootPath();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                path = pathTextBox.Text;
                ListDirectory(treeView, path);
            }
            catch (Exception)
            {
                MessageBox.Show("Can't Find Folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                path = pathTextBox.Text;
                //ListDirectory(treeView1, path);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    ListDirectory(treeView, path);
                    SaveRootPath();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't Find Folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textEditorFontDialog.ShowDialog();
            textEditorRichTextBox.Font = textEditorFontDialog.Font;
        }

        private void SaveRootPath()
        {
            ConfigurationHelper.SetAppSetting("rootPath", path);
        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            System.Diagnostics.Process.Start((treeView.SelectedNode.Tag as TreeNodeMetadata).FullName);
        }


        private void treeView_NodeMouseClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.treeView.SelectedNode = e.Node;
            }
        }

        private void openExternallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start((treeView.SelectedNode.Tag as TreeNodeMetadata).FullName);
        }
    }
}
