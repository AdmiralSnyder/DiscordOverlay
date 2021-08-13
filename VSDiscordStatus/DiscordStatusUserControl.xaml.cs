using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;

namespace VSDiscordStatus
{
    /// <summary>
    /// Interaction logic for DiscordStatusUserControl.
    /// </summary>
    public partial class DiscordStatusUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolWindow1Control"/> class.
        /// </summary>
        public DiscordStatusUserControl()
        {
            InitializeComponent();
        }

        private bool Initialized = false;
        private async void MyToolWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                if (!Initialized)
                {
                    if (IsVisible)
                    {
                        Initialized = true;
                        await LeftWebView.EnsureCoreWebView2Async().ConfigureAwait(true);
                        LeftWebView.Source = new Uri("https://streamkit.discord.com/overlay/voice/143867839282020352/827982833888526366?icon=true&online=true&logo=white&text_color=%23ffffff&text_size=14&text_outline_color=%23000000&text_outline_size=0&text_shadow_color=%23000000&text_shadow_size=0&bg_color=%231e2124&bg_opacity=0.95&bg_shadow_color=%23000000&bg_shadow_size=0&invite_code=csharp&limit_speaking=false&small_avatars=false&hide_names=false&fade_chat=0");

                        await RightWebView.EnsureCoreWebView2Async().ConfigureAwait(true);
                        RightWebView.Source = new Uri("https://streamkit.discord.com/overlay/voice/143867839282020352/827982932311408650?icon=true&online=true&logo=white&text_color=%23ffffff&text_size=8&text_outline_color=%23000000&text_outline_size=0&text_shadow_color=%23000000&text_shadow_size=0&bg_color=%231e2124&bg_opacity=1&bg_shadow_color=%23000000&bg_shadow_size=0&invite_code=csharp&limit_speaking=false&small_avatars=true&hide_names=false&fade_chat=0");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Error occurred in " + nameof(MyToolWindow_IsVisibleChanged))
            }
        }
    }
}