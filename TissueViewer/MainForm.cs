﻿using System;
using System.Windows.Forms;
using System.IO;
using Trinet.Core.IO.Ntfs;
using System.Collections.Generic;

namespace TissueViewer
{
    public partial class MainForm : Form
    {

        public string path = ConfigurationHelper.GetAppSetting("rootPath");

        public int fileCount, folderCount;

        public bool isDirectory(TreeNode treeNode)
        {
            return (treeNode.Tag as TreeNodeMetadata).FSItem == FSItem.Directory;
        }

        public MainForm()
        {
            InitializeComponent();

            iconSetComboBox.SelectedIndex = 0;

            //load Folder structure
            imageViewerRictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            if(ConfigurationHelper.GetAppSetting("restorePath") == "1")
            {
                ListDirectory(treeView, path);
                restorePathCheckBox.Checked = true;
            }
            else
            {
                ListDirectory(treeView, ConfigurationHelper.GetAppSetting("startupPath"));
                restorePathCheckBox.Checked = false;
                path = ConfigurationHelper.GetAppSetting("startupPath");
            }

            pathTextBox.Text = path;

            startupPathTextBox.Text = ConfigurationHelper.GetAppSetting("startupPath");
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            if (String.IsNullOrWhiteSpace(path)) return;

            treeView.Nodes.Clear();
            folderCount = 0;
            fileCount = 0;

            var rootDrectoryInfo = new DirectoryInfo(path);

            treeView.Nodes.Add(CreateDirectoryNode(rootDrectoryInfo));

        }



        private TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            directoryNode.Tag = new TreeNodeMetadata(FSItem.Directory, directoryInfo.FullName, null);
            foreach (var directory in directoryInfo.GetDirectories())
            {

                var createdDir = CreateDirectoryNode(directory);

                directoryNode.Nodes.Add(createdDir);
                folderCount++;
                folderCountLabel.Text = folderCount.ToString() + " Folders Loaded";

                if (iconSetComboBox.SelectedIndex == 0)
                {
                    createdDir.ImageIndex = 1;
                    createdDir.SelectedImageIndex = 1;
                }
            }

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                var fileNode = new TreeNode(file.Name);
                fileNode.Tag = new TreeNodeMetadata(FSItem.File, file.FullName, file.Extension);
                directoryNode.Nodes.Add(fileNode);
                fileCount++;
                fileCountLabel.Text = fileCount.ToString() + " Files Loaded";

                if (iconSetComboBox.SelectedIndex == 0)
                {
                    if (file.Extension == ".txt")
                    {
                        fileNode.ImageIndex = 2;
                    }
                    else if (file.Extension == ".png" || file.Extension == ".jpg" || file.Extension == "jepg")
                    {
                        fileNode.ImageIndex = 3;
                    }
                    else if (file.Extension == ".gif" || file.Extension == ".mp4" || file.Extension == ".mkv")
                    {
                        fileNode.ImageIndex = 4;
                    }
                    else if (file.Extension == ".exe")
                    {
                        fileNode.ImageIndex = 5;
                    }
                    else
                    {
                        fileNode.ImageIndex = 0;
                    }
                }
                else if (iconSetComboBox.SelectedIndex == 1)
                {
                    if (file.Extension == ".txt")
                    {
                        fileNode.ImageIndex = 1;
                    }
                    else if (file.Extension == ".png" || file.Extension == ".jpg" || file.Extension == "jepg")
                    {
                        fileNode.ImageIndex = 2;
                    }
                    else if (file.Extension == ".gif" || file.Extension == ".mp4" || file.Extension == ".mkv")
                    {
                        fileNode.ImageIndex = 3;
                    }
                    else if (file.Extension == ".exe")
                    {
                        fileNode.ImageIndex = 4;
                    }
                }
                else if (iconSetComboBox.SelectedIndex == 3)
                {
                    if (file.Extension == ".txt")
                    {
                        fileNode.ImageIndex = 1;
                    }
                    else if (file.Extension == ".png" || file.Extension == ".jpg" || file.Extension == "jepg")
                    {
                        fileNode.ImageIndex = 2;
                    }
                    else if (file.Extension == ".gif" || file.Extension == ".mp4" || file.Extension == ".mkv")
                    {
                        fileNode.ImageIndex = 3;
                    }
                    else if (file.Extension == ".exe")
                    {
                        fileNode.ImageIndex = 4;
                    }
                }
                else if (iconSetComboBox.SelectedIndex == 4)
                {
                    if (file.Extension == ".txt")
                    {
                        fileNode.ImageIndex = 1;
                    }
                    else if (file.Extension == ".png" || file.Extension == ".jpg" || file.Extension == "jepg")
                    {
                        fileNode.ImageIndex = 2;
                    }
                    else if (file.Extension == ".gif" || file.Extension == ".mp4" || file.Extension == ".mkv")
                    {
                        fileNode.ImageIndex = 3;
                    }
                    else if (file.Extension == ".exe")
                    {
                        fileNode.ImageIndex = 4;
                    }
                }
                else if (iconSetComboBox.SelectedIndex == 5)
                {
                    if (file.Extension == ".txt")
                    {
                        fileNode.ImageIndex = 1;
                    }
                    else if (file.Extension == ".png" || file.Extension == ".jpg" || file.Extension == "jepg")
                    {
                        fileNode.ImageIndex = 2;
                    }
                    else if (file.Extension == ".gif" || file.Extension == ".mp4" || file.Extension == ".mkv")
                    {
                        fileNode.ImageIndex = 3;
                    }
                    else if (file.Extension == ".exe")
                    {
                        fileNode.ImageIndex = 4;
                    }
                }
                else if (iconSetComboBox.SelectedIndex == 6)
                {
                    if (file.Extension == ".txt")
                    {
                        fileNode.ImageIndex = 1;
                    }
                    else if (file.Extension == ".png" || file.Extension == ".jpg" || file.Extension == "jepg")
                    {
                        fileNode.ImageIndex = 2;
                    }
                    else if (file.Extension == ".gif" || file.Extension == ".mp4" || file.Extension == ".mkv")
                    {
                        fileNode.ImageIndex = 3;
                    }
                    else if (file.Extension == ".exe")
                    {
                        fileNode.ImageIndex = 4;
                    }
                }


                fileNode.SelectedImageIndex = fileNode.ImageIndex;


                foreach (AlternateDataStreamInfo ads in file.ListAlternateDataStreams())
                {
                    var adsNode = new TreeNode($":{ads.Name}");
                    adsNode.Tag = new TreeNodeMetadata(FSItem.AlternateFileStream, file.FullName, file.Extension) { StreamName = ads.Name };
                    fileNode.Nodes.Add(adsNode);
                }
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
                if (metadata.FSItem == FSItem.File)
                {
                    textEditorRichTextBox.Text = File.ReadAllText(filePath);
                }
                else if (metadata.FSItem == FSItem.AlternateFileStream)
                {
                    var fileInfo = new FileInfo(metadata.FullName);
                    AlternateDataStreamInfo streamInfo = fileInfo.GetAlternateDataStream(metadata.StreamName, FileMode.Open);
                    using (TextReader reader = streamInfo.OpenText())
                    {
                        textEditorRichTextBox.Text = reader.ReadToEnd();
                    }
                }
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

            if(ConfigurationHelper.GetAppSetting("restorePath") == "1")
            {
                SaveRootPath();
            }
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    path = pathTextBox.Text;
                    ListDirectory(treeView, path);

                    if (ConfigurationHelper.GetAppSetting("restorePath") == "1")
                    {
                        SaveRootPath();
                    }
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
            if (treeView.SelectedNode != null)
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

        private void rememberPathCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (restorePathCheckBox.Checked)
            {
                ConfigurationHelper.SetAppSetting("restorePath", "1");
                startupPathTextBox.Enabled = false;
                startupPathLabel.Enabled = false;
                ConfigurationHelper.SetAppSetting("startupPath", string.Empty);
            }
            else
            {
                ConfigurationHelper.SetAppSetting("restorePath", "0");
                startupPathTextBox.Enabled = true;
                startupPathLabel.Enabled = true;
            }
        }

        private void startupPathTextBox_TextChanged(object sender, EventArgs e)
        {
            ConfigurationHelper.SetAppSetting("startupPath", startupPathTextBox.Text);
        }

        private void startupPathTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    ConfigurationHelper.SetAppSetting("startupPath", startupPathTextBox.Text);

                    if (ConfigurationHelper.GetAppSetting("restorePath") == "1")
                    {
                        SaveRootPath();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't Find Directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shell32Helper.ShowFileProperties((treeView.SelectedNode.Tag as TreeNodeMetadata).FullName);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textEditorRichTextBox.ForeColor = colorDialog1.Color;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textEditorRichTextBox.Clear();
        }
    }
}