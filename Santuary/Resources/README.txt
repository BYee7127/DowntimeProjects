Created:	December 8, 2017
Author:		Carmen Yu

Created - December 8, 2017 12:27
View
	Initialize the form
	Initialize all the member variables, if any
	Call to add a menu to the panel
		All Menu is is a blank/colored background with a title and a start button


Project Sanctuary
	Startup project/View of the solution
	Form1.cs -> Sanctuary.cs
		public Sanctuary(){}
			InitializeComponent();
			Create all the boards/screens here (?)
		protected override bool IsInputKey(Keys data){}
			Most of the basic keys have input, but not the arrows
			Switch them to true if those keys need to be overriden
		protected override bool OnKeyDown(KeyEventArgs e){}
			When a key is pressed, flip a boolean for movement
		protected override bool OnKeyUp(KeyEventArgs e){}
			When a key is depressed, flip the boolean back to false
Project Vector2D
	Gotten from the SpaceWars assignment
	Use it for movement