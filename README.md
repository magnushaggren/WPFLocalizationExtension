# LocalizationExtension v2.1.0#
### Is a really easy way to localize any type of DependencyProperties or native Properties on DependencyObjects ###

### Features:###

* First of all: ITS FREE (and will stay free - refer to license section below)
* Obtain stable results in
	* WPF applications using .NET 3.5 and higher
	* **New:** Silverlight 5.0 applications
	* **New:** Windows Phone applications
* **New:** Localization source/provider can be changed freely at arbitrary nodes
	* Use the Provider property in LocalizeDictionary to change the provider for the particular sub tree
	* Use the DefaultProvider property to set the provider for the whole application
	* Built-in RESX provider for resource file lookup (Default) - **fully backward compatible to older versions of this extension**
	* Interface for custom providers
	* Notification about provider changes and errors
	* Notification about resource changes
	* Get the list of all available cultures from a provider - or just take the bindable merged list from LocalizeDictionary
	* CSV provider project in the Tests folder as an example for custom providers
* BLoc Extension that derives from Binding to support binding scenarios
* Supports binding-like write style like "Text = {lex:LocText ResAssembly:ResFile:ResKey}"
	* Define a default assembly and / or resource file to reduce the key to ResAssembly::ResKey, ResFile:ResKey or even ResKey
	* Automatic key lookup: If no key is specified, the Name and Property Name of the target are used (e.g. MyButton_Content)
	* Default assembly, dictionary and culture can be changed dynamically at the RESX provider
	* Default assembly and dictionary inherit along the visual tree and can be redefined at each node
* It is available at designtime (MS Expression Blend 3.0 & 4.0, MS VisualStudio 2008 & 2010
    * not for dynamic loaded assemblies which only can be found at runtime and as long the resource (.resx) is built at designtime
	* Even for Silverlight!
	* No extra preview application needed
	* Offers a DesignValue Property to support custom values during design mode
* Full support of various application scenarios
	* Works with normal dependency properties
	* Works with normal properties (e.g. Ribbon)
	* Works with control/data templates
* Various culture setup features
	* List of available cultures
	* Culture swapping by Commands (SetCultureCommand)
	* Works with the .resx-fallback mechanism (e.g. en-us -> en -> invariant culture)
	* Supports culture forcing (e.g. "this object has to be in english all the time")
	* Buffering allows fast switching of the language at runtime
	* Offers a design language for visual testing at designtime
	* Offers a "SpecificCulture" to use as IFormatProvider (e.g. (123.20).ToString(LocalizeDictionary.SpecificCulture) = "123.20" or "123,20")
	* Does not alter the culture on Thread.CurrentCulture or Thread.CurrentUICulture (can be changed easily)
* Code behind features:
	* Can be used in code behind to bind localized values to dynamic generated controls
	* Implements INotifyPropertyChanged for advanced use
	* Offers some functionality to check and get resource values in code behind (e.g. ResolveLocalizedValue)
* Easy to use
	* Can be used with any resource file (.resx) accross all assemblies (also the dynamic loaded one at runtime)
	* Does not need any initializing process (like "call xyz to register a special localize dictionary")
	* Can localize any type of data type, as long a TypeConverter exists for it
* Example extensions included for
	* Formating e.g. "this is the '{0}' value" (not bindable at the moment)
	* Prefix and suffix values (currently with LocText extension)
	* Upper and lower Text
* Last, but not least
	* Does not create any memory leaks
	* Leaves the UID property untouched
	* Does not need an additional build task
	* Is in use in various productive systems

### License: ###
Microsoft Public License (Ms-PL)

-----

### Homepage: ###
http://wpflocalizeextension.codeplex.com/  
http://root-project.org/

### NuGet Package: ###
https://nuget.org/packages/WpfLocalizeExtension/

### Based on XAML Markup Extensions: ###
http://xamlmarkupextensions.codeplex.com/