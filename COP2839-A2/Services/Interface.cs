namespace COP2839_A2.Interfaces
{
	public interface IVFRWxService
	{
		bool IsVFR(int belowClouds, int aboveClouds, int horizontalCloudSeparation, int visibility);
	}
}
