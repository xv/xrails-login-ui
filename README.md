Synopsis
========
This project was heavily inspired by a concept design called "Simply Login" [I found on Dribbble](https://dribbble.com/shots/1892468-simply-login). It was made possible for WinForms by designing a bunch of custom, fully functional controls with GDI+ and cramming them into one form to produce this excellent result. Eye candy, eh?

----------

<p align="center">
  <img src ="http://i.imgur.com/sRNuDw0.png" />
</p>

Controls
------------------
Control           | Inherits        
------------------|---------
XRails_Button     | Control          
XRails_Container  | ContainerControl 
XRails_ControlBox | Control          
XRails_Label      | Label            
XRails_LeftPanel  | Panel            
XRails_LinkLabel  | LinkLabel        
XRails_LogoBox    | Control          
XRails_RightPanel | Panel            
XRails_TextBox    | Control          
XRails_TitleLabel | Label            

> **Note**
>
> The control `XRails_TitleLabel` uses a user-defined font called `Raleway-Light`. Because the font will not be installed on the local machine, it needs to be initialized on the form that is using the label in order to load up. See the demo project for more information.
>
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

## Hacky
Ok, look. If you saw the screenshot above closely, you have probably noticed the alien window frame. That right -- it is a custom as well. But how?

There are two controls that make up the custom window frame: `XRails_Container` and `XRails_ControlBox`. The Container control, once placed, will override the form's `FormBorderStyle` property by setting it to None. That alone is not sufficient. The ControlBox control is also needed here. It is basically the Minimize, Maximize, and Close buttons. Once placed, it will automatically adjust location.

Any drawbacks? Absolutely. Natively speaking, when you set `FormBorderStyle = FormBorderStyle.None;`, Windows will disable many things, and that includes: ability to resize form, drop shadow, and DWM form animations.

What about a workaround? Sure -- although not entirely. Form resizing during runtime can be easily coded and implemented in `XRails_Container`, but the functionality is not needed for a project like this. Thus, it is not a problem here. However, it is hacky when it comes to drop shadow. You will need to override `CreateParams` to modify the parameters of the form and `WndProc` to intercept window messages.
<br>As for DWM animations (eg. minimize/maximize/restore), going borderless makes them near impossible to achieve. I have yet to discover a solution for that. However, I did create a simple fade in/out animation for the form when the application is launched or closed.
I highly recommend you have a look at the demo project form to see how everything is done.

Keep in mind that `XRails_Container` is optional! You do not have to override the default window frame. It was made purely to unify the look of the application on any Windows version.

Contact Author
-------
[Email me your love letters](mailto:xviyy@aol.com)
<br>
[Tweet me maybe?](https://twitter.com/xviyy)

Legal
-----
This project is distributed under the terms of the [MIT License](https://opensource.org/licenses/MIT).
