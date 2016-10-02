About this project
===================
This project was heavily inspired by a concept design called "Simply Login" [I found](https://dribbble.com/shots/1892468-simply-login) on Dribbble. It was made possible for WinForms by designing a bunch of custom, fully functional controls with GDI+ and cramming them into one form to produce this excellent result. Eye candy, eh?

----------

<p align="center">
  <img src ="http://i.imgur.com/1P7VwjA.png" />
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

> XRails_TitleLabel uses a custom, user-defined font called <i>Raleway-Light</i>. It needs to be initialized on the form that is using the label. See the code of the sample form provided in the project for more information.

Requirements
------------
* <kbd>[.NET Framework 2.0](https://www.microsoft.com/en-ca/download/details.aspx?id=1639)</kbd> or above.
* <kbd>[Animator](https://github.com/PavelTorgashov/Animator)</kbd> only if you want to animate the controls on the form. Not required by XRails itself.

Implementation
--------------
`XRails Controls.cs` and `Font Loader.cs` are all you need to add to your project and the custom controls should show up in your toolbox after rebuilding  the solution. You could also compile the two class files into a single .dll and use it in VB.NET.

> **Note**

> For this project, make sure you build the solution first before opening the sample form. Otherwise, you may get designer errors.

License
--------
This project is distributed under the [MIT License](https://opensource.org/licenses/MIT)
