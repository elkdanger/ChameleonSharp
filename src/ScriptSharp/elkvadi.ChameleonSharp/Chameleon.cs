using System;
using System.Collections;
using System.Html;
using System.Runtime.CompilerServices;

namespace elkvadi.ChameleonSharp.Core
{
    /// <summary>
    /// Allows access to all Chameleon API methods
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("chameleon")]
    public static class Chameleon
    {
        /// <summary>
        /// Used to Invoke global Chameleon methods that are part of the Chameleon core libraries
        /// Use Type.InvokeMethod using this as the object instance
        /// </summary>
        [ScriptAlias("chameleon")]
        public static Object ChameleonInstance
        {
            get { return null; }
            private set {  }
        }

        /// <summary>
        /// Gets a Versions object containing the version numbers of Chameleon, chameleon.js, and chameleon.jquery.js
        /// </summary>
        /// <returns>Versions object containig the version numbers</returns>
        [ScriptName("version")]
        public static Versions GetVersion()
        {
            return null;
        }

        /// <summary>
        /// returns true if running components meet the specified version requirements.
        /// </summary>
        /// <param name="options">Object containing version numbers to check</param>
        /// <returns>true if running components meet the specified version requirements, otherwise false</returns>
        public static bool Version(VersionRequireOptions options)
        {
            return false;
        }

        /// <summary>
        /// Returns the package name of the Chameleon app currently running. There are two versions of Chameleon in the wild: 
        /// one for our Kickstarters, and another for the general public.
        /// </summary>
        /// <returns></returns>
        public static string GetChameleonPackageName()
        {
            return null;
        }

        /// <summary>
        /// If your widget is using manual initialization, then this function is used to finalize that initialization process 
        /// at your desired time. Remember that you only have 10 seconds after onLoad to call this before Chameleon calls it for you, 
        /// and moves on to loading the next widget.
        /// </summary>
        public static void Initialize()
        {
            return;
        }

        /// <summary>
        /// Will print a log message for this widget. We have not yet exposed a log viewing tool for developers inside of Chameleon. 
        /// Expect this soon.
        /// </summary>
        /// <param name="message"></param>
        public static void Log(string message)
        {
            return;
        }

        /// <summary>
        /// Initialises the current page as a widget. Should only be called once per page
        /// </summary>
        /// <param name="options">Options used to initialise the widget</param>
        public static void Widget(WidgetOptions options)
        {
            return;
        }

        /// <summary>
        /// Triggers the refresh cycle as if the user had pressed the refresh icon in the widget title 
        /// </summary>
        /// <param name="options">Options used to refresh the widget</param>
        public static void Refresh(RefreshOptions options)
        {
            return;
        }


        /// <summary>
        /// Determines if an internet connection is available
        /// </summary>
        /// <returns><c>true</c> if an internet connection is available, otherwise <c>false</c></returns>
        public static bool Connected()
        {
            return false;
        }

        /// <summary>
        /// Determines if the widget's layout is being edited by the user
        /// </summary>
        /// <returns><c>true</c> if the widget's layout is being edited by the user, otherwise <c>false</c></returns>
        public static bool IsInLayoutMode()
        {
            return false;
        }

        /// <summary>
        /// Show a special icon in the title bar that performs an action of your choice. We tend to use this for 
        /// "edit" or "post" operations such as "Tweet" for the Twitter widget, and "Status Update" for the Facebook widget.
        ///
        /// Make sure you set 'allowAction' to true in your widget manifest to use the action button.
        /// </summary>
        /// <param name="options">Options to configure this method</param>
        public static void Action(ActionOptions options)
        {
            return;
        }

        /// <summary>
        /// Use this function to launch Android intents.
        /// </summary>
        public static void Intent(IntentOptions options)
        {
            return;
        }

        /// <summary>
        /// Determines if the specified component(Activity or Service) exists on this device.
        /// </summary>
        /// <returns><c>true</c> if the specified component(Activity or Service) exists on this device, otherwise <c>false</c></returns>
        public static bool ComponentExists(ComponentOptions options)
        {
            return false;
        }

        /// <summary>
        /// This function behaves differently depending on the view type that you are running you HTML as;
        /// WIDGET: The widget is removed from the dashboard so should use the signature with no parameters
        /// WINDOW: The current window is closed and an optional message is passed back to widget that launched it
        /// </summary>
        public static void Close()
        {
            return;
        }

        /// <summary>
        /// This function behaves differently depending on the view type that you are running you HTML as;
        /// WIDGET: The widget is removed from the dashboard so should use the signature with no parameters
        /// WINDOW: The current window is closed and an optional message is passed back to widget that launched it
        /// </summary>
        [AlternateSignature]
        public static extern void Close(bool success, Dictionary data);

        /// <summary>
        /// Returns the type of view this is. Possibilities are "widget" or "window"
        /// </summary>
        /// <returns>The type of view this is</returns>
        public static string GetType()
        {
            return null;
        }

        /// <summary>
        /// Determines if the widget is running in the "Make A Widget" widget.
        /// </summary>
        /// <returns><c>true</c> if the widget is running in the "Make A Widget" widget, otherwise <c>false</c></returns>
        public static bool DevMode()
        {
            return false;
        }

        /// <summary>
        /// Determines if this widget is running in Chameleon.
        /// </summary>
        /// <returns><c>true</c> if the widget is running in Chameleon, otherwise <c>false</c></returns>
        public static bool Exists()
        {
            return false;
        }

        /// <summary>
        /// Scrolls the widget to the top.
        /// </summary>
        public static void Top()
        {
            return;
        }

        /// <summary>
        /// Displays an animation the is displayed over the widget or window.
        /// </summary>
        public static void ShowLoading(LoadingOptions options)
        {
            return;
        }

        /// <summary>
        /// Changes the title in the Widget title bar.
        /// </summary>
        /// <param name="options"></param>
        public static void SetTitle(TitleOptions options)
        {
            return;
        }

        /// <summary>
        ///  launches the specified url in a window that overlays the Dashboard. 
        ///  This function only works when the view type is "widget".
        /// </summary>
        [ScriptName("promptHTML")]
        public static void PromptHTML(PromptHtmlOptions options)
        {
            return;
        }

        /// <summary>
        /// Kicks off an Oauth 1.0 or 2.0 handshake with a remote service provider. 
        /// </summary>
        public static void PromptOauth(OAuthOptions options)
        {
            return;
        }

        /// <summary>
        /// Does only the work of launching a native select list and handling the selected result.
        /// </summary>
        /// <param name="options">Options used to configure the select list</param>
        public static void SelectList(SelectListOptions options)
        {
            return;
        }

        /// <summary>
        /// Save and persist an object that is only accessible to this widget instance.
        /// </summary>
        /// <param name="data">Data to save</param>
        public static void SaveData(Object data)
        {
            return;
        }

        /// <summary>
        /// Returns the instance data object that was previously saved. 
        /// Returns a new object if nothing has ever been saved for this widget instance.
        /// Data stored using this method will be accessible from device to device when future profile
        /// roaming is implemented
        /// </summary>
        /// <returns>The Data</returns>
        public static T GetData<T>()
        {
            return default(T);
        }

        /// <summary>
        /// Save and persist an object that is only accessible to this widget instance.
        /// Data stored using this method will not travel from device to device when future profile roaming is possible
        /// </summary>
        /// <param name="identifier">An identifier for this data block</param>
        /// <param name="data">Data to save</param>
        public static void SaveLocalData(string identifier, Object data)
        {
            return;
        }

        /// <summary>
        /// Retrieve a local data object that was saved previously.
        /// </summary>
        /// <param name="identifier">The id of the data object that was previously saved.</param>
        /// <returns>The Data</returns>
        public static T GetLocalData<T>(string identifier)
        {
            return default(T);
        }

        /// <summary>
        /// Multiple instances of a widget may wish to share data with each other, and Shared data provides this capability. 
        /// The shared data object may be accessed and written to by any instance of a specific widget.
        /// </summary>
        /// <param name="data">Data to be saved</param>
        public static void SaveSharedData(Object data)
        {
            return;
        }

        /// <summary>
        /// Retrieve the data object that is shared amongst all instances of this widget.
        /// </summary>
        /// <returns></returns>
        public static T GetSharedData<T>()
        {
            return default(T);
        }

        /// <summary>
        /// Register a function to be called perpetually on an interval. When you create a poll, you register it by name, 
        /// and may stop it by referring to that name in the future.
        ///
        /// Repeated registers of a poll with the same name will be ignored.
        /// </summary>
        public static void Poll(PollOptions options)
        {
            return;
        }

        /// <summary>
        /// Forces the hosting web-view to clear it's visual state.
        /// </summary>
        public static void Invalidate()
        {
            return;
        }

        /// <summary>
        /// Forces the hosting web-view to clear it's visual state.
        /// </summary>
        public static void InvalidateTwo()
        {
            return;
        }
    }
}
