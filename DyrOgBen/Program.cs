// See https://aka.ms/new-console-template for more information

using DyrOgBen;

// Program.cs
GameManager gameManager = new GameManager();
//UserManager userManager = new UserManager();

gameManager.MainMenu();



// TODO 
// Add hints (✓) 
// Add Try Again (✓)
// Add profiles (✓)
// Add point system () * on hold

// Fix case 1 inside MainMenu():
// Make Login() return _loggedIn or _notLoggedIn?
// Make it possible to start game without logging in
// Make us of the logout method

// Add a class that contains the programs theme/category, difficulty settings
// Add classes that inherits from this one 