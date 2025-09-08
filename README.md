Introduction

The rules that govern piloting an aircraft by seeing and avoiding hazards are called visual flight rules (VFR). If meteorological conditions, primarily clouds, don’t allow safe visual avoidance, pilots must use instruments to navigate following instrument flight rules.
To fly under VFR, you must be able to fly the aircraft with the following cloud clearance and visibility:
•	If below clouds, at least 500 below the cloud ceiling
•	If above clouds, at least 1000 feet above the clouds
•	Horizontal separation from clouds of at least 2000 feet
•	Visibility of at least 3 statute miles

If the above conditions cannot be met, you may not fly following visual flight rules. I attempted to make an app that, given cloud separation distances and visibility, would return a simple statement of either “VFR conditions are met” or “VFR conditions are NOT met”. I’ll save you the trouble of testing this, it doesn’t work. I was not able to get and use the data entered on the user input form.

Route Map

[HttpGet("")]
[HttpGet("Index")]
public IActionResult Index()
{
	return View(); 
}

[HttpGet("Privacy")]
public IActionResult Privacy()
{
    return View("~/Features/Home/Privacy.cshtml");
}
