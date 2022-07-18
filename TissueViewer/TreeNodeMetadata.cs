namespace TissueViewer
{
	public class TreeNodeMetadata
	{
		public FSItem FSItem { get; set; }
		public string FullName { get; set; }
        public string FileExtension { get; set; }

		public TreeNodeMetadata(FSItem fSItem, string fullName, string fileExtension)
        {
            FSItem = fSItem;
            FullName = fullName;
            FileExtension = fileExtension;
        }
    }
}
