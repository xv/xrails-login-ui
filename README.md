Synopsis
========
This project was heavily inspired by a concept design called "Simply Login" [I found on Dribbble](https://dribbble.com/shots/1892468-simply-login). It was made possible for WinForms by designing a bunch of custom, fully functional controls with GDI+ and cramming them into one form to produce this excellent result. Eye candy, eh?

----------

<p align="center">
  <img src ="http://i.imgur.com/S2JGkGp.png" />
</p>

Supported Controls
------------------
Control           | Inherits   | Interface       | Animated | Custom Properties
------------------|------------|-----------------|----------|-------------------
XRails_TopLeftBox | Control    | N/A             | NO       | NO
XRails_LeftPanel  | Panel      | N/A             | NO       | NO
XRails_RightPanel | Panel      | N/A             | NO       | NO
XRails_TitleLabel | Label      | N/A             | NO       | YES
XRails_LinkLabel  | LinkLabel  | N/A             | NO       | NO
XRails_TextBox    | Control    | N/A             | NO       | YES
XRails_Button     | Control    | IButtonControl  | YES      | YES

> **Note**

> `XRails_TitleLabel` control uses a user-defined font called `Raleway-Light`. It needs to be initialized on the form that is using the label in order to load up. See the code of the sample form provided in the project for more information.

Requirements
------------
* <kbd>[.NET Framework 2.0](https://www.microsoft.com/en-ca/download/details.aspx?id=1639)</kbd> or above.
* <kbd>[Animator](https://github.com/PavelTorgashov/Animator)</kbd> only if you want to animate the controls on the form. Not required by XRails itself.

Implementation
--------------
`XRails Controls.cs`, `Font Loader.cs` and `Raleway-Light.ttf` are all you need to add to your project and the custom controls should show up in your toolbox after rebuilding  the solution. You could also compile the three files into a single .dll and use it in VB.NET or Nemerle.

If you are creating a new ClassLibrary project to compile XRails as a .dll, make sure you add a reference to:
* <kbd>System.Drawing</kbd>
* <kbd>System.Windows.Forms</kbd>

> **Important**

> For this project, make sure you build the solution first before opening the sample form. Otherwise, you may get designer errors.

Legal
-----
This project is distributed under the [MIT License](https://opensource.org/licenses/MIT)
