using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordOverlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.Source = new Uri("https://streamkit.discord.com/overlay/voice/143867839282020352/827982932311408650?icon=true&online=true&logo=white&text_color=%23ffffff&text_size=8&text_outline_color=%23000000&text_outline_size=0&text_shadow_color=%23000000&text_shadow_size=0&bg_color=%231e2124&bg_opacity=1&bg_shadow_color=%23000000&bg_shadow_size=0&invite_code=csharp&limit_speaking=false&small_avatars=true&hide_names=false&fade_chat=0");
        }
    }
}
