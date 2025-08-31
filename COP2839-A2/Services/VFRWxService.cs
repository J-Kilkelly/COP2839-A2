namespace COP2839_A2.Services
{
	public class VFRWxService : Interfaces.IVFRWxService
	{
		public bool IsVFR(int belowClouds, int aboveClouds, int horizontalCloudSeparation, int visibility)
		{
			if (belowClouds < 500) return false;
			if (aboveClouds < 1000) return false;
			if (horizontalCloudSeparation < 2000) return false;
			if (visibility < 3) return false;
			return true;
		}
	}
}
