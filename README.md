Synopsis
========
This project was heavily inspired by a concept design called "Simply Login" [I found on Dribbble](https://dribbble.com/shots/1892468-simply-login). It was made possible for WinForms by designing a bunch of custom, fully functional controls with GDI+ and cramming them into one form to produce this excellent result. Eye candy, eh?

----------

<p align="center">
  <img src ="http://i.imgur.com/sRNuDw0.png" />
</p>

Custom Controls
------------------
Control           | Inherits         | Interface      | Animated | Custom Properties
------------------|------------------|----------------|----------|------------------
XRails_Button     | Control          | IButtonControl | YES      | YES
XRails_Container  | ContainerControl | N/A            | NO       | YES
XRails_ControlBox | Control          | N/A            | NO       | YES
XRails_Label      | Label            | N/A            | NO       | NO
XRails_LeftPanel  | Panel            | N/A            | NO       | NO
XRails_LinkLabel  | LinkLabel        | N/A            | NO       | NO
XRails_LogoBox    | Control          | N/A            | NO       | NO
XRails_RightPanel | Panel            | N/A            | NO       | NO
XRails_TextBox    | Control          | N/A            | NO       | YES
XRails_TitleLabel | Label            | N/A            | NO       | YES

> **Note**

> The control `XRails_TitleLabel` uses a user-defined font called `Raleway-Light`. Because the font will not be installed on the local machine, it needs to be initialized on the form that is using the label in order to load up. See the demo project for more information.

> Raleway is an open source font developed by [impallari](https://github.com/impallari/Raleway/), and can be found on [Google Fonts](https://fonts.google.com/specimen/Raleway) as well.

Requirements
------------
* [.NET Framework 2.0](https://www.microsoft.com/en-ca/download/details.aspx?id=1639) or above.
* [Animator](https://github.com/PavelTorgashov/Animator) - only if you want to animate the controls on the form. Not required by XRails itself.

Implementation
--------------
The core project compiles into a single dynamic link library. Meaning that once it is compiled, it can be referenced and used in any WinForms project across the .NET platform.

**Note:** since the compiled .dll contains a set of controls, referencing it to your project itself will not result in showing the custom controls in your Toolbox pane. It is better to do the following:
1. On your Toolbox pane, right-click and select `Add Tab`. Name it and confirm.
2. If not running the IDE as administrator, drag and drop the .dll on the newly created tab and the controls will be listed. Otherwise,
   1. Right-click on the new tab and select `Choose Items...`
   2. Press `Browse...` and navigate to the .dll file.
   3. Press `OK` to confirm. The custom controls show now be listed.

This process does not reference XRrails to your project. Once any of its control is placed on a form, it will be automatically referenced.

Contact Author
-------
[Email me your love letters](mailto:xviyy@aol.com)
<br>
[Tweet me maybe?](https://twitter.com/xviyy)

Legal
-----
This project is distributed under the terms of the [MIT License](https://opensource.org/licenses/MIT).
