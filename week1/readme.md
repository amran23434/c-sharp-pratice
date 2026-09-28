1. Fundamental Programming & Object Concepts
 Objects: Program components containing both data (properties/fields) and operations (methods) used to perform specific tasks.  
 Controls: Visible graphical elements on a Form—such as Labels, TextBoxes, and Buttons—that enhance program functionality. Some controls, like Timers, remain invisible at run time.  
 Classes: Code structures that serve as blueprints describing specific types of objects. Controls are defined by classes provided by the .NET Framework.  
 Event-Driven Programming: GUI applications respond to user actions (events) like clicking or typing. Specific functions called Event Handlers execute in response to those actions.  
2. The Visual Studio IDE Interface
 Designer Window: The graphical workspace where you construct and arrange your application's user interface.  
 Solution Explorer: A window displaying the solution container along with its projects and associated source files (such as ⁠Form1.cs⁠ and ⁠Program.cs⁠).  
 Properties Window: Displays customizable settings (name-value pairs) controlling the appearance and behavior of selected objects.  
 Toolbox: Contains controls grouped into categories (e.g., Common Controls) that can be added to a Form.  
 Window States: Support for Auto Hide (pinned/unpinned), Docked (attached to edges), or Floating (dragged across the screen) modes.  
3. C# Application Code Structure
 Hierarchy: Code is organized sequentially into Namespaces (containers for classes), Classes (containers for methods), and Methods (statements performing operations).  
 Key Source Files:
 ⁠Program.cs⁠: Contains the main startup code that executes when the app runs.  
 ⁠Form1.cs⁠: Contains code and event handlers specifically associated with ⁠Form1⁠.  
 Identifier Rules: Variable and control names must begin with a letter or underscore (⁠_⁠), can contain letters, digits, and underscores, and cannot contain spaces or special characters.  
4. Working with Key Controls & C# Code Features
 Message Boxes: Displayed using ⁠MessageBox.Show("Text")⁠ to show pop-up dialog messages.  
 Label Controls: Used to display static text or output. Key properties include ⁠Text⁠, ⁠Font⁠, ⁠BorderStyle⁠, ⁠AutoSize⁠, and ⁠TextAlign⁠. Text is assigned dynamically via code using the assignment operator (⁠=⁠).  
 PictureBox Controls: Used to show images. Managed via properties like ⁠Image⁠, ⁠SizeMode⁠, and ⁠Visible⁠.  
 Closing Forms: Executed in code using ⁠this.Close();⁠.  
 Code Readability & Debugging:
 Comments: Explanatory notes using ⁠//⁠ for single-line or ⁠/* ... */⁠ for multi-line comments.  
 IntelliSense: IDE feature providing auto-completion suggestions for keywords, controls, and methods.  
 Syntax Errors: Flagged in real time with jagged underlines in the editor.