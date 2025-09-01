namespace COP2839_A2.Models
{
	public class VFRWxInputModel
	{
		public int BelowClouds { get; set; }
		public int AboveClouds { get; set; }
		public int HorizontalCloudSeparation { get; set; }
		public int Visibility { get; set; }
		public bool IsVFR { get; set; }
	}
}
