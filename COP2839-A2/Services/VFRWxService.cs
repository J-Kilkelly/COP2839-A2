namespace COP2839_A2.Services
{
	public class VFRWxService : Interfaces.IVFRWxService
	{
		public bool IsVFR(int BelowClouds, int AboveClouds, int HorizontalCloudSeparation, int Visibility)
		{
			if (BelowClouds < 500) return false;
			if (AboveClouds < 1000) return false;
			if (HorizontalCloudSeparation < 2000) return false;
			if (Visibility < 3) return false;
			return true;
		}
	}
}
