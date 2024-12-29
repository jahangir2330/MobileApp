; ModuleID = 'marshal_methods.x86_64.ll'
source_filename = "marshal_methods.x86_64.ll"
target datalayout = "e-m:e-p270:32:32-p271:32:32-p272:64:64-i64:64-f80:128-n8:16:32:64-S128"
target triple = "x86_64-unknown-linux-android21"

%struct.MarshalMethodName = type {
	i64, ; uint64_t id
	ptr ; char* name
}

%struct.MarshalMethodsManagedClass = type {
	i32, ; uint32_t token
	ptr ; MonoClass klass
}

@assembly_image_cache = dso_local local_unnamed_addr global [366 x ptr] zeroinitializer, align 16

; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = dso_local local_unnamed_addr constant [732 x i64] [
	i64 24362543149721218, ; 0: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 265
	i64 98382396393917666, ; 1: Microsoft.Extensions.Primitives.dll => 0x15d8644ad360ce2 => 209
	i64 120698629574877762, ; 2: Mono.Android => 0x1accec39cafe242 => 175
	i64 131669012237370309, ; 3: Microsoft.Maui.Essentials.dll => 0x1d3c844de55c3c5 => 217
	i64 196720943101637631, ; 4: System.Linq.Expressions.dll => 0x2bae4a7cd73f3ff => 62
	i64 210515253464952879, ; 5: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 251
	i64 229794953483747371, ; 6: System.ValueTuple.dll => 0x330654aed93802b => 155
	i64 232391251801502327, ; 7: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 293
	i64 233177144301842968, ; 8: Xamarin.AndroidX.Collection.Jvm.dll => 0x33c696097d9f218 => 252
	i64 295915112840604065, ; 9: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 296
	i64 316157742385208084, ; 10: Xamarin.AndroidX.Core.Core.Ktx.dll => 0x46337caa7dc1b14 => 259
	i64 350667413455104241, ; 11: System.ServiceProcess.dll => 0x4ddd227954be8f1 => 136
	i64 354178770117062970, ; 12: Microsoft.Extensions.Options.ConfigurationExtensions.dll => 0x4ea4bb703cff13a => 208
	i64 422779754995088667, ; 13: System.IO.UnmanagedMemoryStream => 0x5de03f27ab57d1b => 60
	i64 435118502366263740, ; 14: Xamarin.AndroidX.Security.SecurityCrypto.dll => 0x609d9f8f8bdb9bc => 295
	i64 545109961164950392, ; 15: fi/Microsoft.Maui.Controls.resources.dll => 0x7909e9f1ec38b78 => 335
	i64 560278790331054453, ; 16: System.Reflection.Primitives => 0x7c6829760de3975 => 99
	i64 590337075967009532, ; 17: Microsoft.Maui.Maps.dll => 0x8314c715ec1a2fc => 219
	i64 634308326490598313, ; 18: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 278
	i64 648449422406355874, ; 19: Microsoft.Extensions.Configuration.FileExtensions.dll => 0x8ffc15065568ba2 => 191
	i64 649145001856603771, ; 20: System.Security.SecureString => 0x90239f09b62167b => 133
	i64 668723562677762733, ; 21: Microsoft.Extensions.Configuration.Binder.dll => 0x947c88986577aad => 190
	i64 687654259221141486, ; 22: Xamarin.GooglePlayServices.Base => 0x98b09e7c92917ee => 314
	i64 702024105029695270, ; 23: System.Drawing.Common => 0x9be17343c0e7726 => 228
	i64 750875890346172408, ; 24: System.Threading.Thread => 0xa6ba5a4da7d1ff8 => 149
	i64 798450721097591769, ; 25: Xamarin.AndroidX.Collection.Ktx.dll => 0xb14aab351ad2bd9 => 253
	i64 799765834175365804, ; 26: System.ComponentModel.dll => 0xb1956c9f18442ac => 22
	i64 849051935479314978, ; 27: hi/Microsoft.Maui.Controls.resources.dll => 0xbc8703ca21a3a22 => 338
	i64 872800313462103108, ; 28: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 264
	i64 875677659902526502, ; 29: IdentityModel.dll => 0xc270831303c4426 => 183
	i64 895210737996778430, ; 30: Xamarin.AndroidX.Lifecycle.Runtime.Ktx.dll => 0xc6c6d6c5569cbbe => 279
	i64 940822596282819491, ; 31: System.Transactions => 0xd0e792aa81923a3 => 154
	i64 960778385402502048, ; 32: System.Runtime.Handles.dll => 0xd555ed9e1ca1ba0 => 108
	i64 1010599046655515943, ; 33: System.Reflection.Primitives.dll => 0xe065e7a82401d27 => 99
	i64 1120440138749646132, ; 34: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 308
	i64 1121665720830085036, ; 35: nb/Microsoft.Maui.Controls.resources.dll => 0xf90f507becf47ac => 346
	i64 1268860745194512059, ; 36: System.Drawing.dll => 0x119be62002c19ebb => 40
	i64 1269279639035949735, ; 37: Validation => 0x119d631b555fb2a7 => 230
	i64 1301626418029409250, ; 38: System.Diagnostics.FileVersionInfo => 0x12104e54b4e833e2 => 32
	i64 1315114680217950157, ; 39: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 242
	i64 1369545283391376210, ; 40: Xamarin.AndroidX.Navigation.Fragment.dll => 0x13019a2dd85acb52 => 286
	i64 1404195534211153682, ; 41: System.IO.FileSystem.Watcher.dll => 0x137cb4660bd87f12 => 54
	i64 1425944114962822056, ; 42: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 119
	i64 1476839205573959279, ; 43: System.Net.Primitives.dll => 0x147ec96ece9b1e6f => 74
	i64 1486715745332614827, ; 44: Microsoft.Maui.Controls.dll => 0x14a1e017ea87d6ab => 213
	i64 1491290866305144020, ; 45: Xamarin.Google.AutoValue.Annotations.dll => 0x14b2212446e714d4 => 309
	i64 1492954217099365037, ; 46: System.Net.HttpListener => 0x14b809f350210aad => 69
	i64 1513467482682125403, ; 47: Mono.Android.Runtime => 0x1500eaa8245f6c5b => 174
	i64 1537168428375924959, ; 48: System.Threading.Thread.dll => 0x15551e8a954ae0df => 149
	i64 1556147632182429976, ; 49: ko/Microsoft.Maui.Controls.resources.dll => 0x15988c06d24c8918 => 344
	i64 1576750169145655260, ; 50: Xamarin.AndroidX.Window.Extensions.Core.Core => 0x15e1bdecc376bfdc => 307
	i64 1596440484026710920, ; 51: en-US/CLL.resources.dll => 0x1627b2297376fb88 => 1
	i64 1624659445732251991, ; 52: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 241
	i64 1628611045998245443, ; 53: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 282
	i64 1636321030536304333, ; 54: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 272
	i64 1639340239664632727, ; 55: Microsoft.AspNetCore.Cryptography.Internal.dll => 0x16c01b432b36d397 => 184
	i64 1651782184287836205, ; 56: System.Globalization.Calendars => 0x16ec4f2524cb982d => 44
	i64 1659332977923810219, ; 57: System.Reflection.DispatchProxy => 0x1707228d493d63ab => 93
	i64 1682513316613008342, ; 58: System.Net.dll => 0x17597cf276952bd6 => 85
	i64 1731380447121279447, ; 59: Newtonsoft.Json => 0x18071957e9b889d7 => 221
	i64 1735388228521408345, ; 60: System.Net.Mail.dll => 0x181556663c69b759 => 70
	i64 1743969030606105336, ; 61: System.Memory.dll => 0x1833d297e88f2af8 => 66
	i64 1767386781656293639, ; 62: System.Private.Uri.dll => 0x188704e9f5582107 => 90
	i64 1795316252682057001, ; 63: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 240
	i64 1825687700144851180, ; 64: System.Runtime.InteropServices.RuntimeInformation.dll => 0x1956254a55ef08ec => 110
	i64 1835311033149317475, ; 65: es\Microsoft.Maui.Controls.resources => 0x197855a927386163 => 334
	i64 1836611346387731153, ; 66: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 293
	i64 1854145951182283680, ; 67: System.Runtime.CompilerServices.VisualC => 0x19bb3feb3df2e3a0 => 106
	i64 1875417405349196092, ; 68: System.Drawing.Primitives => 0x1a06d2319b6c713c => 39
	i64 1875917498431009007, ; 69: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 237
	i64 1881198190668717030, ; 70: tr\Microsoft.Maui.Controls.resources => 0x1a1b5bc992ea9be6 => 356
	i64 1897575647115118287, ; 71: Xamarin.AndroidX.Security.SecurityCrypto => 0x1a558aff4cba86cf => 295
	i64 1920760634179481754, ; 72: Microsoft.Maui.Controls.Xaml => 0x1aa7e99ec2d2709a => 215
	i64 1930726298510463061, ; 73: CommunityToolkit.Mvvm.dll => 0x1acb5156cd389055 => 181
	i64 1959996714666907089, ; 74: tr/Microsoft.Maui.Controls.resources.dll => 0x1b334ea0a2a755d1 => 356
	i64 1972385128188460614, ; 75: System.Security.Cryptography.Algorithms => 0x1b5f51d2edefbe46 => 123
	i64 1981742497975770890, ; 76: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 280
	i64 1983698669889758782, ; 77: cs/Microsoft.Maui.Controls.resources.dll => 0x1b87836e2031a63e => 330
	i64 2019660174692588140, ; 78: pl/Microsoft.Maui.Controls.resources.dll => 0x1c07463a6f8e1a6c => 348
	i64 2040001226662520565, ; 79: System.Threading.Tasks.Extensions.dll => 0x1c4f8a4ea894a6f5 => 146
	i64 2062890601515140263, ; 80: System.Threading.Tasks.Dataflow => 0x1ca0dc1289cd44a7 => 145
	i64 2064708342624596306, ; 81: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x1ca7514c5eecb152 => 321
	i64 2080945842184875448, ; 82: System.IO.MemoryMappedFiles => 0x1ce10137d8416db8 => 57
	i64 2102659300918482391, ; 83: System.Drawing.Primitives.dll => 0x1d2e257e6aead5d7 => 39
	i64 2106033277907880740, ; 84: System.Threading.Tasks.Dataflow.dll => 0x1d3a221ba6d9cb24 => 145
	i64 2133195048986300728, ; 85: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 221
	i64 2165252314452558154, ; 86: Xamarin.AndroidX.Camera.Camera2.dll => 0x1e0c85820c09814a => 246
	i64 2165310824878145998, ; 87: Xamarin.Android.Glide.GifDecoder => 0x1e0cbab9112b81ce => 234
	i64 2165725771938924357, ; 88: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 245
	i64 2187106081561765979, ; 89: PInvoke.BCrypt.dll => 0x1e5a2964b595e85b => 223
	i64 2200176636225660136, ; 90: Microsoft.Extensions.Logging.Debug.dll => 0x1e8898fe5d5824e8 => 206
	i64 2262844636196693701, ; 91: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 264
	i64 2287834202362508563, ; 92: System.Collections.Concurrent => 0x1fc00515e8ce7513 => 12
	i64 2287887973817120656, ; 93: System.ComponentModel.DataAnnotations.dll => 0x1fc035fd8d41f790 => 18
	i64 2302323944321350744, ; 94: ru/Microsoft.Maui.Controls.resources.dll => 0x1ff37f6ddb267c58 => 352
	i64 2304837677853103545, ; 95: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0x1ffc6da80d5ed5b9 => 292
	i64 2315304989185124968, ; 96: System.IO.FileSystem.dll => 0x20219d9ee311aa68 => 55
	i64 2329709569556905518, ; 97: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 275
	i64 2335503487726329082, ; 98: System.Text.Encodings.Web => 0x2069600c4d9d1cfa => 140
	i64 2337758774805907496, ; 99: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 105
	i64 2470498323731680442, ; 100: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 257
	i64 2479423007379663237, ; 101: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 302
	i64 2497223385847772520, ; 102: System.Runtime => 0x22a7eb7046413568 => 120
	i64 2547086958574651984, ; 103: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 235
	i64 2592350477072141967, ; 104: System.Xml.dll => 0x23f9e10627330e8f => 167
	i64 2602673633151553063, ; 105: th\Microsoft.Maui.Controls.resources => 0x241e8de13a460e27 => 355
	i64 2612152650457191105, ; 106: Microsoft.IdentityModel.Tokens.dll => 0x24403afeed9892c1 => 211
	i64 2624866290265602282, ; 107: mscorlib.dll => 0x246d65fbde2db8ea => 170
	i64 2632269733008246987, ; 108: System.Net.NameResolution => 0x2487b36034f808cb => 71
	i64 2656907746661064104, ; 109: Microsoft.Extensions.DependencyInjection => 0x24df3b84c8b75da8 => 193
	i64 2662981627730767622, ; 110: cs\Microsoft.Maui.Controls.resources => 0x24f4cfae6c48af06 => 330
	i64 2706075432581334785, ; 111: System.Net.WebSockets => 0x258de944be6c0701 => 84
	i64 2717258904505065223, ; 112: AppConfig.dll => 0x25b5a493b5ca9f07 => 362
	i64 2783046991838674048, ; 113: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 105
	i64 2787234703088983483, ; 114: Xamarin.AndroidX.Startup.StartupRuntime => 0x26ae3f31ef429dbb => 297
	i64 2815524396660695947, ; 115: System.Security.AccessControl => 0x2712c0857f68238b => 121
	i64 2895129759130297543, ; 116: fi\Microsoft.Maui.Controls.resources => 0x282d912d479fa4c7 => 335
	i64 2923871038697555247, ; 117: Jsr305Binding => 0x2893ad37e69ec52f => 310
	i64 3017136373564924869, ; 118: System.Net.WebProxy => 0x29df058bd93f63c5 => 82
	i64 3017704767998173186, ; 119: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 308
	i64 3077266195237102513, ; 120: en-US\CLL.resources => 0x2ab4a54cee6ce3b1 => 1
	i64 3106852385031680087, ; 121: System.Runtime.Serialization.Xml => 0x2b1dc1c88b637057 => 118
	i64 3110390492489056344, ; 122: System.Security.Cryptography.Csp.dll => 0x2b2a53ac61900058 => 125
	i64 3135773902340015556, ; 123: System.IO.FileSystem.DriveInfo.dll => 0x2b8481c008eac5c4 => 52
	i64 3281594302220646930, ; 124: System.Security.Principal => 0x2d8a90a198ceba12 => 132
	i64 3289520064315143713, ; 125: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 273
	i64 3303437397778967116, ; 126: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 238
	i64 3311221304742556517, ; 127: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 86
	i64 3325875462027654285, ; 128: System.Runtime.Numerics => 0x2e27e21c8958b48d => 114
	i64 3328853167529574890, ; 129: System.Net.Sockets.dll => 0x2e327651a008c1ea => 79
	i64 3344514922410554693, ; 130: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x2e6a1a9a18463545 => 324
	i64 3396143930648122816, ; 131: Microsoft.Extensions.FileProviders.Abstractions => 0x2f2186e9506155c0 => 197
	i64 3411255996856937470, ; 132: Xamarin.GooglePlayServices.Basement => 0x2f5737416a942bfe => 315
	i64 3429672777697402584, ; 133: Microsoft.Maui.Essentials => 0x2f98a5385a7b1ed8 => 217
	i64 3437845325506641314, ; 134: System.IO.MemoryMappedFiles.dll => 0x2fb5ae1beb8f7da2 => 57
	i64 3493805808809882663, ; 135: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 299
	i64 3494946837667399002, ; 136: Microsoft.Extensions.Configuration => 0x30808ba1c00a455a => 188
	i64 3508450208084372758, ; 137: System.Net.Ping => 0x30b084e02d03ad16 => 73
	i64 3522470458906976663, ; 138: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 298
	i64 3531994851595924923, ; 139: System.Numerics => 0x31042a9aade235bb => 87
	i64 3551103847008531295, ; 140: System.Private.CoreLib.dll => 0x31480e226177735f => 176
	i64 3567343442040498961, ; 141: pt\Microsoft.Maui.Controls.resources => 0x3181bff5bea4ab11 => 350
	i64 3571415421602489686, ; 142: System.Runtime.dll => 0x319037675df7e556 => 120
	i64 3638003163729360188, ; 143: Microsoft.Extensions.Configuration.Abstractions => 0x327cc89a39d5f53c => 189
	i64 3647754201059316852, ; 144: System.Xml.ReaderWriter => 0x329f6d1e86145474 => 160
	i64 3655542548057982301, ; 145: Microsoft.Extensions.Configuration.dll => 0x32bb18945e52855d => 188
	i64 3659371656528649588, ; 146: Xamarin.Android.Glide.Annotations => 0x32c8b3222885dd74 => 232
	i64 3709516231136365052, ; 147: en-US/MobileApp.resources.dll => 0x337ad95bbd6dc9fc => 3
	i64 3716579019761409177, ; 148: netstandard.dll => 0x3393f0ed5c8c5c99 => 171
	i64 3727469159507183293, ; 149: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 291
	i64 3772598417116884899, ; 150: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 265
	i64 3869221888984012293, ; 151: Microsoft.Extensions.Logging.dll => 0x35b23cceda0ed605 => 204
	i64 3869649043256705283, ; 152: System.Diagnostics.Tools => 0x35b3c14d74bf0103 => 36
	i64 3889433610606858880, ; 153: Microsoft.Extensions.FileProviders.Physical.dll => 0x35fa0b4301afd280 => 198
	i64 3890352374528606784, ; 154: Microsoft.Maui.Controls.Xaml.dll => 0x35fd4edf66e00240 => 215
	i64 3900304704209712960, ; 155: PInvoke.NCrypt.dll => 0x3620aa76ba347740 => 225
	i64 3908285696359564448, ; 156: Plugin.Maui.Biometric => 0x363d0522444084a0 => 227
	i64 3919223565570527920, ; 157: System.Security.Cryptography.Encoding => 0x3663e111652bd2b0 => 126
	i64 3933965368022646939, ; 158: System.Net.Requests => 0x369840a8bfadc09b => 76
	i64 3966267475168208030, ; 159: System.Memory => 0x370b03412596249e => 66
	i64 4006972109285359177, ; 160: System.Xml.XmlDocument => 0x379b9fe74ed9fe49 => 165
	i64 4009997192427317104, ; 161: System.Runtime.Serialization.Primitives => 0x37a65f335cf1a770 => 117
	i64 4012137326867063711, ; 162: CLL => 0x37adf9a43dff239f => 364
	i64 4073500526318903918, ; 163: System.Private.Xml.dll => 0x3887fb25779ae26e => 92
	i64 4073631083018132676, ; 164: Microsoft.Maui.Controls.Compatibility.dll => 0x388871e311491cc4 => 212
	i64 4120493066591692148, ; 165: zh-Hant\Microsoft.Maui.Controls.resources => 0x392eee9cdda86574 => 361
	i64 4148881117810174540, ; 166: System.Runtime.InteropServices.JavaScript.dll => 0x3993c9651a66aa4c => 109
	i64 4154383907710350974, ; 167: System.ComponentModel => 0x39a7562737acb67e => 22
	i64 4167269041631776580, ; 168: System.Threading.ThreadPool => 0x39d51d1d3df1cf44 => 150
	i64 4168469861834746866, ; 169: System.Security.Claims.dll => 0x39d96140fb94ebf2 => 122
	i64 4187479170553454871, ; 170: System.Linq.Expressions => 0x3a1cea1e912fa117 => 62
	i64 4201423742386704971, ; 171: Xamarin.AndroidX.Core.Core.Ktx => 0x3a4e74a233da124b => 259
	i64 4204911241079711850, ; 172: ar-KW/MobileApp.resources.dll => 0x3a5ad87ec49a686a => 2
	i64 4205801962323029395, ; 173: System.ComponentModel.TypeConverter => 0x3a5e0299f7e7ad93 => 21
	i64 4235503420553921860, ; 174: System.IO.IsolatedStorage.dll => 0x3ac787eb9b118544 => 56
	i64 4247996603072512073, ; 175: Xamarin.GooglePlayServices.Tasks => 0x3af3ea6755340049 => 317
	i64 4282138915307457788, ; 176: System.Reflection.Emit => 0x3b6d36a7ddc70cfc => 96
	i64 4326933140005261798, ; 177: Xamarin.AndroidX.Biometric => 0x3c0c5ac408e111e6 => 244
	i64 4356591372459378815, ; 178: vi/Microsoft.Maui.Controls.resources.dll => 0x3c75b8c562f9087f => 358
	i64 4373617458794931033, ; 179: System.IO.Pipes.dll => 0x3cb235e806eb2359 => 59
	i64 4397634830160618470, ; 180: System.Security.SecureString.dll => 0x3d0789940f9be3e6 => 133
	i64 4477672992252076438, ; 181: System.Web.HttpUtility.dll => 0x3e23e3dcdb8ba196 => 156
	i64 4484706122338676047, ; 182: System.Globalization.Extensions.dll => 0x3e3ce07510042d4f => 45
	i64 4533124835995628778, ; 183: System.Reflection.Emit.dll => 0x3ee8e505540534ea => 96
	i64 4636684751163556186, ; 184: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 303
	i64 4657212095206026001, ; 185: Microsoft.Extensions.Http.dll => 0x40a1bdb9c2686b11 => 200
	i64 4671688737346305267, ; 186: PInvoke.Kernel32.dll => 0x40d52c27aab83cf3 => 224
	i64 4672453897036726049, ; 187: System.IO.FileSystem.Watcher => 0x40d7e4104a437f21 => 54
	i64 4679594760078841447, ; 188: ar/Microsoft.Maui.Controls.resources.dll => 0x40f142a407475667 => 328
	i64 4716677666592453464, ; 189: System.Xml.XmlSerializer => 0x417501590542f358 => 166
	i64 4725285941539738176, ; 190: Xamarin.AndroidX.Camera.Lifecycle => 0x41939687379f9240 => 248
	i64 4743821336939966868, ; 191: System.ComponentModel.Annotations => 0x41d5705f4239b194 => 17
	i64 4759461199762736555, ; 192: Xamarin.AndroidX.Lifecycle.Process.dll => 0x420d00be961cc5ab => 277
	i64 4783554999938465879, ; 193: CommunityToolkit.Maui.Markup.dll => 0x426299ed96e04057 => 180
	i64 4794310189461587505, ; 194: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 235
	i64 4795410492532947900, ; 195: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 298
	i64 4809057822547766521, ; 196: System.Drawing => 0x42bd349c3145ecf9 => 40
	i64 4814660307502931973, ; 197: System.Net.NameResolution.dll => 0x42d11c0a5ee2a005 => 71
	i64 4853321196694829351, ; 198: System.Runtime.Loader.dll => 0x435a75ea15de7927 => 113
	i64 5055365687667823624, ; 199: Xamarin.AndroidX.Activity.Ktx.dll => 0x4628444ef7239408 => 236
	i64 5081566143765835342, ; 200: System.Resources.ResourceManager.dll => 0x4685597c05d06e4e => 103
	i64 5099468265966638712, ; 201: System.Resources.ResourceManager => 0x46c4f35ea8519678 => 103
	i64 5103417709280584325, ; 202: System.Collections.Specialized => 0x46d2fb5e161b6285 => 15
	i64 5182934613077526976, ; 203: System.Collections.Specialized.dll => 0x47ed7b91fa9009c0 => 15
	i64 5205316157927637098, ; 204: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 284
	i64 5244375036463807528, ; 205: System.Diagnostics.Contracts.dll => 0x48c7c34f4d59fc28 => 29
	i64 5262971552273843408, ; 206: System.Security.Principal.dll => 0x4909d4be0c44c4d0 => 132
	i64 5278787618751394462, ; 207: System.Net.WebClient.dll => 0x4942055efc68329e => 80
	i64 5280980186044710147, ; 208: Xamarin.AndroidX.Lifecycle.LiveData.Core.Ktx.dll => 0x4949cf7fd7123d03 => 276
	i64 5290786973231294105, ; 209: System.Runtime.Loader => 0x496ca6b869b72699 => 113
	i64 5376510917114486089, ; 210: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 302
	i64 5384358006512718399, ; 211: PCLCrypto.dll => 0x4ab9151451b8923f => 222
	i64 5408338804355907810, ; 212: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 300
	i64 5423376490970181369, ; 213: System.Runtime.InteropServices.RuntimeInformation => 0x4b43b42f2b7b6ef9 => 110
	i64 5440320908473006344, ; 214: Microsoft.VisualBasic.Core => 0x4b7fe70acda9f908 => 6
	i64 5446034149219586269, ; 215: System.Diagnostics.Debug => 0x4b94333452e150dd => 30
	i64 5451019430259338467, ; 216: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 255
	i64 5457765010617926378, ; 217: System.Xml.Serialization => 0x4bbde05c557002ea => 161
	i64 5471532531798518949, ; 218: sv\Microsoft.Maui.Controls.resources => 0x4beec9d926d82ca5 => 354
	i64 5507995362134886206, ; 219: System.Core.dll => 0x4c705499688c873e => 25
	i64 5522859530602327440, ; 220: uk\Microsoft.Maui.Controls.resources => 0x4ca5237b51eead90 => 357
	i64 5527431512186326818, ; 221: System.IO.FileSystem.Primitives.dll => 0x4cb561acbc2a8f22 => 53
	i64 5570799893513421663, ; 222: System.IO.Compression.Brotli => 0x4d4f74fcdfa6c35f => 47
	i64 5573260873512690141, ; 223: System.Security.Cryptography.dll => 0x4d58333c6e4ea1dd => 130
	i64 5573669443803475672, ; 224: Microsoft.Maui.Controls.Maps => 0x4d59a6d41d5aeed8 => 214
	i64 5574231584441077149, ; 225: Xamarin.AndroidX.Annotation.Jvm => 0x4d5ba617ae5f8d9d => 239
	i64 5591791169662171124, ; 226: System.Linq.Parallel => 0x4d9a087135e137f4 => 63
	i64 5650097808083101034, ; 227: System.Security.Cryptography.Algorithms.dll => 0x4e692e055d01a56a => 123
	i64 5692067934154308417, ; 228: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 305
	i64 5724799082821825042, ; 229: Xamarin.AndroidX.ExifInterface => 0x4f72926f3e13b212 => 268
	i64 5741990095351817038, ; 230: Microsoft.Extensions.Localization.Abstractions.dll => 0x4fafa591c141a34e => 203
	i64 5757522595884336624, ; 231: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 254
	i64 5783556987928984683, ; 232: Microsoft.VisualBasic => 0x504352701bbc3c6b => 7
	i64 5896680224035167651, ; 233: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 274
	i64 5959344983920014087, ; 234: Xamarin.AndroidX.SavedState.SavedState.Ktx.dll => 0x52b3d8b05c8ef307 => 294
	i64 5979151488806146654, ; 235: System.Formats.Asn1 => 0x52fa3699a489d25e => 42
	i64 5984759512290286505, ; 236: System.Security.Cryptography.Primitives => 0x530e23115c33dba9 => 128
	i64 6010974535988770325, ; 237: Microsoft.Extensions.Diagnostics.dll => 0x536b457e33877615 => 195
	i64 6068057819846744445, ; 238: ro/Microsoft.Maui.Controls.resources.dll => 0x5436126fec7f197d => 351
	i64 6102788177522843259, ; 239: Xamarin.AndroidX.SavedState.SavedState.Ktx => 0x54b1758374b3de7b => 294
	i64 6200764641006662125, ; 240: ro\Microsoft.Maui.Controls.resources => 0x560d8a96830131ed => 351
	i64 6222399776351216807, ; 241: System.Text.Json.dll => 0x565a67a0ffe264a7 => 141
	i64 6251069312384999852, ; 242: System.Transactions.Local => 0x56c0426b870da1ac => 153
	i64 6278736998281604212, ; 243: System.Private.DataContractSerialization => 0x57228e08a4ad6c74 => 89
	i64 6284145129771520194, ; 244: System.Reflection.Emit.ILGeneration => 0x5735c4b3610850c2 => 94
	i64 6319713645133255417, ; 245: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 278
	i64 6357457916754632952, ; 246: _Microsoft.Android.Resource.Designer => 0x583a3a4ac2a7a0f8 => 365
	i64 6401687960814735282, ; 247: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 275
	i64 6478287442656530074, ; 248: hr\Microsoft.Maui.Controls.resources => 0x59e7801b0c6a8e9a => 339
	i64 6504860066809920875, ; 249: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 245
	i64 6548213210057960872, ; 250: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 261
	i64 6557084851308642443, ; 251: Xamarin.AndroidX.Window.dll => 0x5aff71ee6c58c08b => 306
	i64 6560151584539558821, ; 252: Microsoft.Extensions.Options => 0x5b0a571be53243a5 => 207
	i64 6589202984700901502, ; 253: Xamarin.Google.ErrorProne.Annotations.dll => 0x5b718d34180a787e => 312
	i64 6591971792923354531, ; 254: Xamarin.AndroidX.Lifecycle.LiveData.Core.Ktx => 0x5b7b636b7e9765a3 => 276
	i64 6617685658146568858, ; 255: System.Text.Encoding.CodePages => 0x5bd6be0b4905fa9a => 137
	i64 6713440830605852118, ; 256: System.Reflection.TypeExtensions.dll => 0x5d2aeeddb8dd7dd6 => 100
	i64 6739853162153639747, ; 257: Microsoft.VisualBasic.dll => 0x5d88c4bde075ff43 => 7
	i64 6743165466166707109, ; 258: nl\Microsoft.Maui.Controls.resources => 0x5d948943c08c43a5 => 347
	i64 6772837112740759457, ; 259: System.Runtime.InteropServices.JavaScript => 0x5dfdf378527ec7a1 => 109
	i64 6777482997383978746, ; 260: pt/Microsoft.Maui.Controls.resources.dll => 0x5e0e74e0a2525efa => 350
	i64 6786606130239981554, ; 261: System.Diagnostics.TraceSource => 0x5e2ede51877147f2 => 37
	i64 6798329586179154312, ; 262: System.Windows => 0x5e5884bd523ca188 => 158
	i64 6814185388980153342, ; 263: System.Xml.XDocument.dll => 0x5e90d98217d1abfe => 162
	i64 6876862101832370452, ; 264: System.Xml.Linq => 0x5f6f85a57d108914 => 159
	i64 6894844156784520562, ; 265: System.Numerics.Vectors => 0x5faf683aead1ad72 => 86
	i64 6985504089449394141, ; 266: ZXing.Net.MAUI.Controls.dll => 0x60f17ef564ab6fdd => 327
	i64 7011053663211085209, ; 267: Xamarin.AndroidX.Fragment.Ktx => 0x614c442918e5dd99 => 270
	i64 7060896174307865760, ; 268: System.Threading.Tasks.Parallel.dll => 0x61fd57a90988f4a0 => 147
	i64 7083547580668757502, ; 269: System.Private.Xml.Linq.dll => 0x624dd0fe8f56c5fe => 91
	i64 7101497697220435230, ; 270: System.Configuration => 0x628d9687c0141d1e => 23
	i64 7103753931438454322, ; 271: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 271
	i64 7112547816752919026, ; 272: System.IO.FileSystem => 0x62b4d88e3189b1f2 => 55
	i64 7141281584637745974, ; 273: Xamarin.GooglePlayServices.Maps.dll => 0x631aedc3dd5f1b36 => 316
	i64 7192745174564810625, ; 274: Xamarin.Android.Glide.GifDecoder.dll => 0x63d1c3a0a1d72f81 => 234
	i64 7220009545223068405, ; 275: sv/Microsoft.Maui.Controls.resources.dll => 0x6432a06d99f35af5 => 354
	i64 7243049202045766964, ; 276: MongoDB.Bson.dll => 0x64847adfba9d4d34 => 220
	i64 7270811800166795866, ; 277: System.Linq => 0x64e71ccf51a90a5a => 65
	i64 7299370801165188114, ; 278: System.IO.Pipes.AccessControl.dll => 0x654c9311e74f3c12 => 58
	i64 7316205155833392065, ; 279: Microsoft.Win32.Primitives => 0x658861d38954abc1 => 8
	i64 7338192458477945005, ; 280: System.Reflection => 0x65d67f295d0740ad => 101
	i64 7349431895026339542, ; 281: Xamarin.Android.Glide.DiskLruCache => 0x65fe6d5e9bf88ed6 => 233
	i64 7377312882064240630, ; 282: System.ComponentModel.TypeConverter.dll => 0x66617afac45a2ff6 => 21
	i64 7378352852197400208, ; 283: MobileApp.dll => 0x66652cd3aeb75e90 => 4
	i64 7488575175965059935, ; 284: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 159
	i64 7489048572193775167, ; 285: System.ObjectModel => 0x67ee71ff6b419e3f => 88
	i64 7592577537120840276, ; 286: System.Diagnostics.Process => 0x695e410af5b2aa54 => 33
	i64 7637303409920963731, ; 287: System.IO.Compression.ZipFile.dll => 0x69fd26fcb637f493 => 49
	i64 7654504624184590948, ; 288: System.Net.Http => 0x6a3a4366801b8264 => 68
	i64 7694700312542370399, ; 289: System.Net.Mail => 0x6ac9112a7e2cda5f => 70
	i64 7708790323521193081, ; 290: ms/Microsoft.Maui.Controls.resources.dll => 0x6afb1ff4d1730479 => 345
	i64 7714652370974252055, ; 291: System.Private.CoreLib => 0x6b0ff375198b9c17 => 176
	i64 7725404731275645577, ; 292: Xamarin.AndroidX.Lifecycle.Runtime.Ktx => 0x6b3626ac11ce9289 => 279
	i64 7735176074855944702, ; 293: Microsoft.CSharp => 0x6b58dda848e391fe => 5
	i64 7735352534559001595, ; 294: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 319
	i64 7756332380610150586, ; 295: Xamarin.Google.AutoValue.Annotations => 0x6ba407349220c0ba => 309
	i64 7791074099216502080, ; 296: System.IO.FileSystem.AccessControl.dll => 0x6c1f749d468bcd40 => 51
	i64 7820441508502274321, ; 297: System.Data => 0x6c87ca1e14ff8111 => 28
	i64 7820573243100514395, ; 298: Validation.dll => 0x6c8841edeeee485b => 230
	i64 7836164640616011524, ; 299: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 241
	i64 7919757340696389605, ; 300: Microsoft.Extensions.Diagnostics.Abstractions => 0x6de8a157378027e5 => 196
	i64 7972383140441761405, ; 301: Microsoft.Extensions.Caching.Abstractions.dll => 0x6ea3983a0b58267d => 187
	i64 8025517457475554965, ; 302: WindowsBase => 0x6f605d9b4786ce95 => 169
	i64 8031450141206250471, ; 303: System.Runtime.Intrinsics.dll => 0x6f757159d9dc03e7 => 112
	i64 8064050204834738623, ; 304: System.Collections.dll => 0x6fe942efa61731bf => 16
	i64 8083354569033831015, ; 305: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 273
	i64 8085230611270010360, ; 306: System.Net.Http.Json.dll => 0x703482674fdd05f8 => 67
	i64 8087206902342787202, ; 307: System.Diagnostics.DiagnosticSource => 0x703b87d46f3aa082 => 31
	i64 8103644804370223335, ; 308: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 27
	i64 8113615946733131500, ; 309: System.Reflection.Extensions => 0x70995ab73cf916ec => 97
	i64 8167236081217502503, ; 310: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 172
	i64 8185542183669246576, ; 311: System.Collections => 0x7198e33f4794aa70 => 16
	i64 8187640529827139739, ; 312: Xamarin.KotlinX.Coroutines.Android => 0x71a057ae90f0109b => 323
	i64 8229019213283651918, ; 313: ar-KW\CLL.resources => 0x7233596011a2f14e => 0
	i64 8246048515196606205, ; 314: Microsoft.Maui.Graphics.dll => 0x726fd96f64ee56fd => 218
	i64 8264926008854159966, ; 315: System.Diagnostics.Process.dll => 0x72b2ea6a64a3a25e => 33
	i64 8290740647658429042, ; 316: System.Runtime.Extensions => 0x730ea0b15c929a72 => 107
	i64 8308610922448049511, ; 317: MongoDB.Bson => 0x734e1d9cf1725567 => 220
	i64 8318905602908530212, ; 318: System.ComponentModel.DataAnnotations => 0x7372b092055ea624 => 18
	i64 8320777595162576093, ; 319: Xamarin.AndroidX.Camera.View => 0x737957232eb1c4dd => 249
	i64 8368701292315763008, ; 320: System.Security.Cryptography => 0x7423997c6fd56140 => 130
	i64 8398329775253868912, ; 321: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 256
	i64 8400357532724379117, ; 322: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 288
	i64 8410671156615598628, ; 323: System.Reflection.Emit.Lightweight.dll => 0x74b8b4daf4b25224 => 95
	i64 8426919725312979251, ; 324: Xamarin.AndroidX.Lifecycle.Process => 0x74f26ed7aa033133 => 277
	i64 8442828414178614895, ; 325: Microsoft.AspNetCore.Cryptography.KeyDerivation => 0x752af3b5eeb0de6f => 185
	i64 8453144032365170736, ; 326: Microsoft.Extensions.Identity.Stores.dll => 0x754f99b5f456d030 => 202
	i64 8518412311883997971, ; 327: System.Collections.Immutable => 0x76377add7c28e313 => 13
	i64 8563666267364444763, ; 328: System.Private.Uri => 0x76d841191140ca5b => 90
	i64 8598790081731763592, ; 329: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x77550a055fc61d88 => 267
	i64 8599632406834268464, ; 330: CommunityToolkit.Maui => 0x7758081c784b4930 => 178
	i64 8601935802264776013, ; 331: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 300
	i64 8614108721271900878, ; 332: pt-BR/Microsoft.Maui.Controls.resources.dll => 0x778b763e14018ace => 349
	i64 8623059219396073920, ; 333: System.Net.Quic.dll => 0x77ab42ac514299c0 => 75
	i64 8626175481042262068, ; 334: Java.Interop => 0x77b654e585b55834 => 172
	i64 8629545377263870989, ; 335: Xamarin.AndroidX.Camera.Core.dll => 0x77c24dcca0ed640d => 247
	i64 8638972117149407195, ; 336: Microsoft.CSharp.dll => 0x77e3cb5e8b31d7db => 5
	i64 8639588376636138208, ; 337: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 287
	i64 8648495978913578441, ; 338: Microsoft.Win32.Registry.dll => 0x7805a1456889bdc9 => 9
	i64 8677882282824630478, ; 339: pt-BR\Microsoft.Maui.Controls.resources => 0x786e07f5766b00ce => 349
	i64 8684531736582871431, ; 340: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 48
	i64 8693746513512620959, ; 341: ar-KW/CLL.resources.dll => 0x78a664648135e39f => 0
	i64 8725526185868997716, ; 342: System.Diagnostics.DiagnosticSource.dll => 0x79174bd613173454 => 31
	i64 8816904670177563593, ; 343: Microsoft.Extensions.Diagnostics => 0x7a5bf015646a93c9 => 195
	i64 8853378295825400934, ; 344: Xamarin.Kotlin.StdLib.Common.dll => 0x7add84a720d38466 => 320
	i64 8941376889969657626, ; 345: System.Xml.XDocument => 0x7c1626e87187471a => 162
	i64 8951477988056063522, ; 346: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0x7c3a09cd9ccf5e22 => 290
	i64 8954753533646919997, ; 347: System.Runtime.Serialization.Json => 0x7c45ace50032d93d => 116
	i64 9045785047181495996, ; 348: zh-HK\Microsoft.Maui.Controls.resources => 0x7d891592e3cb0ebc => 359
	i64 9131857290992441898, ; 349: Xamarin.AndroidX.Camera.Core => 0x7ebadfd2d12a5a2a => 247
	i64 9138683372487561558, ; 350: System.Security.Cryptography.Csp => 0x7ed3201bc3e3d156 => 125
	i64 9312692141327339315, ; 351: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 305
	i64 9324707631942237306, ; 352: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 240
	i64 9427266486299436557, ; 353: Microsoft.IdentityModel.Logging.dll => 0x82d460ebe6d2a60d => 210
	i64 9468215723722196442, ; 354: System.Xml.XPath.XDocument.dll => 0x8365dc09353ac5da => 163
	i64 9508211702228543126, ; 355: Microsoft.AspNetCore.Cryptography.KeyDerivation.dll => 0x83f3f42aa08b6696 => 185
	i64 9554839972845591462, ; 356: System.ServiceModel.Web => 0x84999c54e32a1ba6 => 135
	i64 9575902398040817096, ; 357: Xamarin.Google.Crypto.Tink.Android.dll => 0x84e4707ee708bdc8 => 311
	i64 9584643793929893533, ; 358: System.IO.dll => 0x85037ebfbbd7f69d => 61
	i64 9603529763312239011, ; 359: Plugin.Maui.Biometric.dll => 0x85469770241e01a3 => 227
	i64 9650158550865574924, ; 360: Microsoft.Extensions.Configuration.Json => 0x85ec4012c28a7c0c => 192
	i64 9659729154652888475, ; 361: System.Text.RegularExpressions => 0x860e407c9991dd9b => 142
	i64 9662334977499516867, ; 362: System.Numerics.dll => 0x8617827802b0cfc3 => 87
	i64 9667360217193089419, ; 363: System.Diagnostics.StackTrace => 0x86295ce5cd89898b => 34
	i64 9678050649315576968, ; 364: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 257
	i64 9702891218465930390, ; 365: System.Collections.NonGeneric.dll => 0x86a79827b2eb3c96 => 14
	i64 9780093022148426479, ; 366: Xamarin.AndroidX.Window.Extensions.Core.Core.dll => 0x87b9dec9576efaef => 307
	i64 9808709177481450983, ; 367: Mono.Android.dll => 0x881f890734e555e7 => 175
	i64 9825649861376906464, ; 368: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 254
	i64 9834056768316610435, ; 369: System.Transactions.dll => 0x8879968718899783 => 154
	i64 9836529246295212050, ; 370: System.Reflection.Metadata => 0x88825f3bbc2ac012 => 98
	i64 9864374015518639636, ; 371: Microsoft.AspNetCore.Cryptography.Internal => 0x88e54be746950614 => 184
	i64 9875200773399460291, ; 372: Xamarin.GooglePlayServices.Base.dll => 0x890bc2c8482339c3 => 314
	i64 9907349773706910547, ; 373: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x897dfa20b758db53 => 267
	i64 9933555792566666578, ; 374: System.Linq.Queryable.dll => 0x89db145cf475c552 => 64
	i64 9956195530459977388, ; 375: Microsoft.Maui => 0x8a2b8315b36616ac => 216
	i64 9974604633896246661, ; 376: System.Xml.Serialization.dll => 0x8a6cea111a59dd85 => 161
	i64 9991543690424095600, ; 377: es/Microsoft.Maui.Controls.resources.dll => 0x8aa9180c89861370 => 334
	i64 10017511394021241210, ; 378: Microsoft.Extensions.Logging.Debug => 0x8b055989ae10717a => 206
	i64 10038780035334861115, ; 379: System.Net.Http.dll => 0x8b50e941206af13b => 68
	i64 10051358222726253779, ; 380: System.Private.Xml => 0x8b7d990c97ccccd3 => 92
	i64 10078727084704864206, ; 381: System.Net.WebSockets.Client => 0x8bded4e257f117ce => 83
	i64 10089571585547156312, ; 382: System.IO.FileSystem.AccessControl => 0x8c055be67469bb58 => 51
	i64 10092835686693276772, ; 383: Microsoft.Maui.Controls => 0x8c10f49539bd0c64 => 213
	i64 10105485790837105934, ; 384: System.Threading.Tasks.Parallel => 0x8c3de5c91d9a650e => 147
	i64 10143853363526200146, ; 385: da\Microsoft.Maui.Controls.resources => 0x8cc634e3c2a16b52 => 331
	i64 10205853378024263619, ; 386: Microsoft.Extensions.Configuration.Binder => 0x8da279930adb4fc3 => 190
	i64 10226222362177979215, ; 387: Xamarin.Kotlin.StdLib.Jdk7 => 0x8dead70ebbc6434f => 321
	i64 10229024438826829339, ; 388: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 261
	i64 10236703004850800690, ; 389: System.Net.ServicePoint.dll => 0x8e101325834e4832 => 78
	i64 10245369515835430794, ; 390: System.Reflection.Emit.Lightweight => 0x8e2edd4ad7fc978a => 95
	i64 10258340260528075680, ; 391: CommunityToolkit.Maui.Markup => 0x8e5cf21daddd33a0 => 180
	i64 10318047534812931528, ; 392: Xamarin.AndroidX.Biometric.dll => 0x8f311190c81ea5c8 => 244
	i64 10321854143672141184, ; 393: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 318
	i64 10360651442923773544, ; 394: System.Text.Encoding => 0x8fc86d98211c1e68 => 139
	i64 10364469296367737616, ; 395: System.Reflection.Emit.ILGeneration.dll => 0x8fd5fde967711b10 => 94
	i64 10376576884623852283, ; 396: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 299
	i64 10406448008575299332, ; 397: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x906b2153fcb3af04 => 324
	i64 10430153318873392755, ; 398: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 258
	i64 10506226065143327199, ; 399: ca\Microsoft.Maui.Controls.resources => 0x91cd9cf11ed169df => 329
	i64 10539579458193346866, ; 400: PInvoke.Windows.Core.dll => 0x92441bad179e5132 => 226
	i64 10546663366131771576, ; 401: System.Runtime.Serialization.Json.dll => 0x925d4673efe8e8b8 => 116
	i64 10566960649245365243, ; 402: System.Globalization.dll => 0x92a562b96dcd13fb => 46
	i64 10595762989148858956, ; 403: System.Xml.XPath.XDocument => 0x930bb64cc472ea4c => 163
	i64 10634102643060048396, ; 404: IdentityModel => 0x9393ec0310a3020c => 183
	i64 10670374202010151210, ; 405: Microsoft.Win32.Primitives.dll => 0x9414c8cd7b4ea92a => 8
	i64 10714184849103829812, ; 406: System.Runtime.Extensions.dll => 0x94b06e5aa4b4bb34 => 107
	i64 10785150219063592792, ; 407: System.Net.Primitives => 0x95ac8cfb68830758 => 74
	i64 10809043855025277762, ; 408: Microsoft.Extensions.Options.ConfigurationExtensions => 0x9601701e0c668b42 => 208
	i64 10822644899632537592, ; 409: System.Linq.Queryable => 0x9631c23204ca5ff8 => 64
	i64 10830817578243619689, ; 410: System.Formats.Tar => 0x964ecb340a447b69 => 43
	i64 10847732767863316357, ; 411: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 242
	i64 10880838204485145808, ; 412: CommunityToolkit.Maui.dll => 0x970080b2a4d614d0 => 178
	i64 10899834349646441345, ; 413: System.Web => 0x9743fd975946eb81 => 157
	i64 10943875058216066601, ; 414: System.IO.UnmanagedMemoryStream.dll => 0x97e07461df39de29 => 60
	i64 10964653383833615866, ; 415: System.Diagnostics.Tracing => 0x982a4628ccaffdfa => 38
	i64 11002576679268595294, ; 416: Microsoft.Extensions.Logging.Abstractions => 0x98b1013215cd365e => 205
	i64 11009005086950030778, ; 417: Microsoft.Maui.dll => 0x98c7d7cc621ffdba => 216
	i64 11019817191295005410, ; 418: Xamarin.AndroidX.Annotation.Jvm.dll => 0x98ee415998e1b2e2 => 239
	i64 11023048688141570732, ; 419: System.Core => 0x98f9bc61168392ac => 25
	i64 11037814507248023548, ; 420: System.Xml => 0x992e31d0412bf7fc => 167
	i64 11050168729868392624, ; 421: Microsoft.AspNetCore.Http.Features => 0x995a15e9dbef58b0 => 186
	i64 11071824625609515081, ; 422: Xamarin.Google.ErrorProne.Annotations => 0x99a705d600e0a049 => 312
	i64 11103970607964515343, ; 423: hu\Microsoft.Maui.Controls.resources => 0x9a193a6fc41a6c0f => 340
	i64 11136029745144976707, ; 424: Jsr305Binding.dll => 0x9a8b200d4f8cd543 => 310
	i64 11162124722117608902, ; 425: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 304
	i64 11188319605227840848, ; 426: System.Threading.Overlapped => 0x9b44e5671724e550 => 144
	i64 11220793807500858938, ; 427: ja\Microsoft.Maui.Controls.resources => 0x9bb8448481fdd63a => 343
	i64 11226290749488709958, ; 428: Microsoft.Extensions.Options.dll => 0x9bcbcbf50c874146 => 207
	i64 11235648312900863002, ; 429: System.Reflection.DispatchProxy.dll => 0x9bed0a9c8fac441a => 93
	i64 11299661109949763898, ; 430: Xamarin.AndroidX.Collection.Jvm => 0x9cd075e94cda113a => 252
	i64 11316886082480137767, ; 431: ar-KW\MobileApp.resources => 0x9d0da7eebdca6627 => 2
	i64 11329751333533450475, ; 432: System.Threading.Timer.dll => 0x9d3b5ccf6cc500eb => 151
	i64 11340910727871153756, ; 433: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 260
	i64 11347436699239206956, ; 434: System.Xml.XmlSerializer.dll => 0x9d7a318e8162502c => 166
	i64 11392833485892708388, ; 435: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 289
	i64 11432101114902388181, ; 436: System.AppContext => 0x9ea6fb64e61a9dd5 => 10
	i64 11446671985764974897, ; 437: Mono.Android.Export => 0x9edabf8623efc131 => 173
	i64 11448276831755070604, ; 438: System.Diagnostics.TextWriterTraceListener => 0x9ee0731f77186c8c => 35
	i64 11485890710487134646, ; 439: System.Runtime.InteropServices => 0x9f6614bf0f8b71b6 => 111
	i64 11508496261504176197, ; 440: Xamarin.AndroidX.Fragment.Ktx.dll => 0x9fb664600dde1045 => 270
	i64 11513602507638267977, ; 441: System.IO.Pipelines.dll => 0x9fc8887aa0d36049 => 229
	i64 11518296021396496455, ; 442: id\Microsoft.Maui.Controls.resources => 0x9fd9353475222047 => 341
	i64 11529969570048099689, ; 443: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 304
	i64 11530571088791430846, ; 444: Microsoft.Extensions.Logging => 0xa004d1504ccd66be => 204
	i64 11580057168383206117, ; 445: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 237
	i64 11591352189662810718, ; 446: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0xa0dcc167234c525e => 297
	i64 11597308262950669618, ; 447: Microsoft.Extensions.Identity.Core.dll => 0xa0f1ea6b83e08d32 => 201
	i64 11597940890313164233, ; 448: netstandard => 0xa0f429ca8d1805c9 => 171
	i64 11622657603305904499, ; 449: Microsoft.Extensions.Identity.Stores => 0xa14bf982bf0a9973 => 202
	i64 11672361001936329215, ; 450: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 271
	i64 11692977985522001935, ; 451: System.Threading.Overlapped.dll => 0xa245cd869980680f => 144
	i64 11705530742807338875, ; 452: he/Microsoft.Maui.Controls.resources.dll => 0xa272663128721f7b => 337
	i64 11707554492040141440, ; 453: System.Linq.Parallel.dll => 0xa27996c7fe94da80 => 63
	i64 11743665907891708234, ; 454: System.Threading.Tasks => 0xa2f9e1ec30c0214a => 148
	i64 11939416560205642949, ; 455: Camera.MAUI => 0xa5b1541a90793cc5 => 177
	i64 11991047634523762324, ; 456: System.Net => 0xa668c24ad493ae94 => 85
	i64 12040886584167504988, ; 457: System.Net.ServicePoint => 0xa719d28d8e121c5c => 78
	i64 12048689113179125827, ; 458: Microsoft.Extensions.FileProviders.Physical => 0xa7358ae968287843 => 198
	i64 12058074296353848905, ; 459: Microsoft.Extensions.FileSystemGlobbing.dll => 0xa756e2afa5707e49 => 199
	i64 12063623837170009990, ; 460: System.Security => 0xa76a99f6ce740786 => 134
	i64 12096697103934194533, ; 461: System.Diagnostics.Contracts => 0xa7e019eccb7e8365 => 29
	i64 12102847907131387746, ; 462: System.Buffers => 0xa7f5f40c43256f62 => 11
	i64 12123043025855404482, ; 463: System.Reflection.Extensions.dll => 0xa83db366c0e359c2 => 97
	i64 12137774235383566651, ; 464: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 301
	i64 12145679461940342714, ; 465: System.Text.Json => 0xa88e1f1ebcb62fba => 141
	i64 12191646537372739477, ; 466: Xamarin.Android.Glide.dll => 0xa9316dee7f392795 => 231
	i64 12201331334810686224, ; 467: System.Runtime.Serialization.Primitives.dll => 0xa953d6341e3bd310 => 117
	i64 12269460666702402136, ; 468: System.Collections.Immutable.dll => 0xaa45e178506c9258 => 13
	i64 12313367145828839434, ; 469: System.IO.Pipelines => 0xaae1de2e1c17f00a => 229
	i64 12332222936682028543, ; 470: System.Runtime.Handles => 0xab24db6c07db5dff => 108
	i64 12341818387765915815, ; 471: CommunityToolkit.Maui.Core.dll => 0xab46f26f152bf0a7 => 179
	i64 12375446203996702057, ; 472: System.Configuration.dll => 0xabbe6ac12e2e0569 => 23
	i64 12451044538927396471, ; 473: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 269
	i64 12466513435562512481, ; 474: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 283
	i64 12475113361194491050, ; 475: _Microsoft.Android.Resource.Designer.dll => 0xad2081818aba1caa => 365
	i64 12487638416075308985, ; 476: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 263
	i64 12517810545449516888, ; 477: System.Diagnostics.TraceSource.dll => 0xadb8325e6f283f58 => 37
	i64 12538491095302438457, ; 478: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 250
	i64 12550732019250633519, ; 479: System.IO.Compression => 0xae2d28465e8e1b2f => 50
	i64 12563127765671202949, ; 480: PInvoke.NCrypt => 0xae593223fcadd085 => 225
	i64 12596101561894695879, ; 481: PCLCrypto => 0xaece57a22f79f3c7 => 222
	i64 12681088699309157496, ; 482: it/Microsoft.Maui.Controls.resources.dll => 0xaffc46fc178aec78 => 342
	i64 12699999919562409296, ; 483: System.Diagnostics.StackTrace.dll => 0xb03f76a3ad01c550 => 34
	i64 12700543734426720211, ; 484: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 251
	i64 12708238894395270091, ; 485: System.IO => 0xb05cbbf17d3ba3cb => 61
	i64 12708922737231849740, ; 486: System.Text.Encoding.Extensions => 0xb05f29e50e96e90c => 138
	i64 12717050818822477433, ; 487: System.Runtime.Serialization.Xml.dll => 0xb07c0a5786811679 => 118
	i64 12753841065332862057, ; 488: Xamarin.AndroidX.Window => 0xb0febee04cf46c69 => 306
	i64 12760970142902902754, ; 489: Xamarin.AndroidX.Camera.Lifecycle.dll => 0xb11812bc0517dfe2 => 248
	i64 12802378574698232169, ; 490: BDO => 0xb1ab2f7bd8f5b969 => 363
	i64 12823819093633476069, ; 491: th/Microsoft.Maui.Controls.resources.dll => 0xb1f75b85abe525e5 => 355
	i64 12828192437253469131, ; 492: Xamarin.Kotlin.StdLib.Jdk8.dll => 0xb206e50e14d873cb => 322
	i64 12835242264250840079, ; 493: System.IO.Pipes => 0xb21ff0d5d6c0740f => 59
	i64 12843321153144804894, ; 494: Microsoft.Extensions.Primitives => 0xb23ca48abd74d61e => 209
	i64 12843770487262409629, ; 495: System.AppContext.dll => 0xb23e3d357debf39d => 10
	i64 12859557719246324186, ; 496: System.Net.WebHeaderCollection.dll => 0xb276539ce04f41da => 81
	i64 12963446364377008305, ; 497: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 228
	i64 12982280885948128408, ; 498: Xamarin.AndroidX.CustomView.PoolingContainer => 0xb42a53aec5481c98 => 262
	i64 12983926868845145925, ; 499: MobileApp => 0xb4302cb2072a2f45 => 4
	i64 12984721484263083342, ; 500: en-US\MobileApp.resources => 0xb432ff64d8e24d4e => 3
	i64 13066492115845567480, ; 501: Camera.MAUI.dll => 0xb5558159a16ad3f8 => 177
	i64 13068258254871114833, ; 502: System.Runtime.Serialization.Formatters.dll => 0xb55bc7a4eaa8b451 => 115
	i64 13129914918964716986, ; 503: Xamarin.AndroidX.Emoji2.dll => 0xb636d40db3fe65ba => 266
	i64 13173818576982874404, ; 504: System.Runtime.CompilerServices.VisualC.dll => 0xb6d2ce32a8819924 => 106
	i64 13221551921002590604, ; 505: ca/Microsoft.Maui.Controls.resources.dll => 0xb77c636bdebe318c => 329
	i64 13222659110913276082, ; 506: ja/Microsoft.Maui.Controls.resources.dll => 0xb78052679c1178b2 => 343
	i64 13343850469010654401, ; 507: Mono.Android.Runtime.dll => 0xb92ee14d854f44c1 => 174
	i64 13370592475155966277, ; 508: System.Runtime.Serialization => 0xb98de304062ea945 => 119
	i64 13381594904270902445, ; 509: he\Microsoft.Maui.Controls.resources => 0xb9b4f9aaad3e94ad => 337
	i64 13401370062847626945, ; 510: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 301
	i64 13404347523447273790, ; 511: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 256
	i64 13431476299110033919, ; 512: System.Net.WebClient => 0xba663087f18829ff => 80
	i64 13454009404024712428, ; 513: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 313
	i64 13463706743370286408, ; 514: System.Private.DataContractSerialization.dll => 0xbad8b1f3069e0548 => 89
	i64 13465488254036897740, ; 515: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 319
	i64 13467053111158216594, ; 516: uk/Microsoft.Maui.Controls.resources.dll => 0xbae49573fde79792 => 357
	i64 13491513212026656886, ; 517: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 243
	i64 13540124433173649601, ; 518: vi\Microsoft.Maui.Controls.resources => 0xbbe82f6eede718c1 => 358
	i64 13545416393490209236, ; 519: id/Microsoft.Maui.Controls.resources.dll => 0xbbfafc7174bc99d4 => 341
	i64 13550417756503177631, ; 520: Microsoft.Extensions.FileProviders.Abstractions.dll => 0xbc0cc1280684799f => 197
	i64 13572454107664307259, ; 521: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 291
	i64 13578472628727169633, ; 522: System.Xml.XPath => 0xbc706ce9fba5c261 => 164
	i64 13580399111273692417, ; 523: Microsoft.VisualBasic.Core.dll => 0xbc77450a277fbd01 => 6
	i64 13621154251410165619, ; 524: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0xbd080f9faa1acf73 => 262
	i64 13647894001087880694, ; 525: System.Data.dll => 0xbd670f48cb071df6 => 28
	i64 13675589307506966157, ; 526: Xamarin.AndroidX.Activity.Ktx => 0xbdc97404d0153e8d => 236
	i64 13702626353344114072, ; 527: System.Diagnostics.Tools.dll => 0xbe29821198fb6d98 => 36
	i64 13710614125866346983, ; 528: System.Security.AccessControl.dll => 0xbe45e2e7d0b769e7 => 121
	i64 13713329104121190199, ; 529: System.Dynamic.Runtime => 0xbe4f8829f32b5737 => 41
	i64 13717397318615465333, ; 530: System.ComponentModel.Primitives.dll => 0xbe5dfc2ef2f87d75 => 20
	i64 13755568601956062840, ; 531: fr/Microsoft.Maui.Controls.resources.dll => 0xbee598c36b1b9678 => 336
	i64 13768883594457632599, ; 532: System.IO.IsolatedStorage => 0xbf14e6adb159cf57 => 56
	i64 13814445057219246765, ; 533: hr/Microsoft.Maui.Controls.resources.dll => 0xbfb6c49664b43aad => 339
	i64 13828521679616088467, ; 534: Xamarin.Kotlin.StdLib.Common => 0xbfe8c733724e1993 => 320
	i64 13881769479078963060, ; 535: System.Console.dll => 0xc0a5f3cade5c6774 => 24
	i64 13911222732217019342, ; 536: System.Security.Cryptography.OpenSsl.dll => 0xc10e975ec1226bce => 127
	i64 13928444506500929300, ; 537: System.Windows.dll => 0xc14bc67b8bba9714 => 158
	i64 13959074834287824816, ; 538: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 269
	i64 14075334701871371868, ; 539: System.ServiceModel.Web.dll => 0xc355a25647c5965c => 135
	i64 14100563506285742564, ; 540: da/Microsoft.Maui.Controls.resources.dll => 0xc3af43cd0cff89e4 => 331
	i64 14124974489674258913, ; 541: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 250
	i64 14125464355221830302, ; 542: System.Threading.dll => 0xc407bafdbc707a9e => 152
	i64 14178052285788134900, ; 543: Xamarin.Android.Glide.Annotations.dll => 0xc4c28f6f75511df4 => 232
	i64 14212104595480609394, ; 544: System.Security.Cryptography.Cng.dll => 0xc53b89d4a4518272 => 124
	i64 14220608275227875801, ; 545: System.Diagnostics.FileVersionInfo.dll => 0xc559bfe1def019d9 => 32
	i64 14226382999226559092, ; 546: System.ServiceProcess => 0xc56e43f6938e2a74 => 136
	i64 14232023429000439693, ; 547: System.Resources.Writer.dll => 0xc5824de7789ba78d => 104
	i64 14254574811015963973, ; 548: System.Text.Encoding.Extensions.dll => 0xc5d26c4442d66545 => 138
	i64 14261073672896646636, ; 549: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 289
	i64 14298246716367104064, ; 550: System.Web.dll => 0xc66d93a217f4e840 => 157
	i64 14316535876961222820, ; 551: Xamarin.AndroidX.Camera.Camera2 => 0xc6ae8d872068c0a4 => 246
	i64 14327695147300244862, ; 552: System.Reflection.dll => 0xc6d632d338eb4d7e => 101
	i64 14327709162229390963, ; 553: System.Security.Cryptography.X509Certificates => 0xc6d63f9253cade73 => 129
	i64 14331727281556788554, ; 554: Xamarin.Android.Glide.DiskLruCache.dll => 0xc6e48607a2f7954a => 233
	i64 14346402571976470310, ; 555: System.Net.Ping.dll => 0xc718a920f3686f26 => 73
	i64 14461014870687870182, ; 556: System.Net.Requests.dll => 0xc8afd8683afdece6 => 76
	i64 14464374589798375073, ; 557: ru\Microsoft.Maui.Controls.resources => 0xc8bbc80dcb1e5ea1 => 352
	i64 14486659737292545672, ; 558: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 274
	i64 14495724990987328804, ; 559: Xamarin.AndroidX.ResourceInspection.Annotation => 0xc92b2913e18d5d24 => 292
	i64 14522721392235705434, ; 560: el/Microsoft.Maui.Controls.resources.dll => 0xc98b12295c2cf45a => 333
	i64 14551742072151931844, ; 561: System.Text.Encodings.Web.dll => 0xc9f22c50f1b8fbc4 => 140
	i64 14556034074661724008, ; 562: CommunityToolkit.Maui.Core => 0xca016bdea6b19f68 => 179
	i64 14561513370130550166, ; 563: System.Security.Cryptography.Primitives.dll => 0xca14e3428abb8d96 => 128
	i64 14574160591280636898, ; 564: System.Net.Quic => 0xca41d1d72ec783e2 => 75
	i64 14622043554576106986, ; 565: System.Runtime.Serialization.Formatters => 0xcaebef2458cc85ea => 115
	i64 14644440854989303794, ; 566: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 284
	i64 14669215534098758659, ; 567: Microsoft.Extensions.DependencyInjection.dll => 0xcb9385ceb3993c03 => 193
	i64 14690985099581930927, ; 568: System.Web.HttpUtility => 0xcbe0dd1ca5233daf => 156
	i64 14705122255218365489, ; 569: ko\Microsoft.Maui.Controls.resources => 0xcc1316c7b0fb5431 => 344
	i64 14744092281598614090, ; 570: zh-Hans\Microsoft.Maui.Controls.resources => 0xcc9d89d004439a4a => 360
	i64 14792063746108907174, ; 571: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 313
	i64 14832630590065248058, ; 572: System.Security.Claims => 0xcdd816ef5d6e873a => 122
	i64 14852515768018889994, ; 573: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 260
	i64 14889905118082851278, ; 574: GoogleGson.dll => 0xcea391d0969961ce => 182
	i64 14892012299694389861, ; 575: zh-Hant/Microsoft.Maui.Controls.resources.dll => 0xceab0e490a083a65 => 361
	i64 14904040806490515477, ; 576: ar\Microsoft.Maui.Controls.resources => 0xced5ca2604cb2815 => 328
	i64 14912225920358050525, ; 577: System.Security.Principal.Windows => 0xcef2de7759506add => 131
	i64 14935719434541007538, ; 578: System.Text.Encoding.CodePages.dll => 0xcf4655b160b702b2 => 137
	i64 14954917835170835695, ; 579: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xcf8a8a895a82ecef => 194
	i64 14984936317414011727, ; 580: System.Net.WebHeaderCollection => 0xcff5302fe54ff34f => 81
	i64 14987728460634540364, ; 581: System.IO.Compression.dll => 0xcfff1ba06622494c => 50
	i64 14988210264188246988, ; 582: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 263
	i64 15015154896917945444, ; 583: System.Net.Security.dll => 0xd0608bd33642dc64 => 77
	i64 15024878362326791334, ; 584: System.Net.Http.Json => 0xd0831743ebf0f4a6 => 67
	i64 15051741671811457419, ; 585: Microsoft.Extensions.Diagnostics.Abstractions.dll => 0xd0e2874d8f44218b => 196
	i64 15071021337266399595, ; 586: System.Resources.Reader.dll => 0xd127060e7a18a96b => 102
	i64 15076659072870671916, ; 587: System.ObjectModel.dll => 0xd13b0d8c1620662c => 88
	i64 15078961294903233180, ; 588: PInvoke.Kernel32 => 0xd1433b67ec924a9c => 224
	i64 15111608613780139878, ; 589: ms\Microsoft.Maui.Controls.resources => 0xd1b737f831192f66 => 345
	i64 15115185479366240210, ; 590: System.IO.Compression.Brotli.dll => 0xd1c3ed1c1bc467d2 => 47
	i64 15133485256822086103, ; 591: System.Linq.dll => 0xd204f0a9127dd9d7 => 65
	i64 15150743910298169673, ; 592: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xd2424150783c3149 => 290
	i64 15227001540531775957, ; 593: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd3512d3999b8e9d5 => 189
	i64 15234786388537674379, ; 594: System.Dynamic.Runtime.dll => 0xd36cd580c5be8a8b => 41
	i64 15250465174479574862, ; 595: System.Globalization.Calendars.dll => 0xd3a489469852174e => 44
	i64 15272359115529052076, ; 596: Xamarin.AndroidX.Collection.Ktx => 0xd3f251b2fb4edfac => 253
	i64 15279429628684179188, ; 597: Xamarin.KotlinX.Coroutines.Android.dll => 0xd40b704b1c4c96f4 => 323
	i64 15299439993936780255, ; 598: System.Xml.XPath.dll => 0xd452879d55019bdf => 164
	i64 15338463749992804988, ; 599: System.Resources.Reader => 0xd4dd2b839286f27c => 102
	i64 15370028218478381000, ; 600: Microsoft.Extensions.Localization.Abstractions => 0xd54d4f3b162247c8 => 203
	i64 15370334346939861994, ; 601: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 258
	i64 15391712275433856905, ; 602: Microsoft.Extensions.DependencyInjection.Abstractions => 0xd59a58c406411f89 => 194
	i64 15526743539506359484, ; 603: System.Text.Encoding.dll => 0xd77a12fc26de2cbc => 139
	i64 15527772828719725935, ; 604: System.Console => 0xd77dbb1e38cd3d6f => 24
	i64 15530465045505749832, ; 605: System.Net.HttpListener.dll => 0xd7874bacc9fdb348 => 69
	i64 15536481058354060254, ; 606: de\Microsoft.Maui.Controls.resources => 0xd79cab34eec75bde => 332
	i64 15541854775306130054, ; 607: System.Security.Cryptography.X509Certificates.dll => 0xd7afc292e8d49286 => 129
	i64 15557562860424774966, ; 608: System.Net.Sockets => 0xd7e790fe7a6dc536 => 79
	i64 15582737692548360875, ; 609: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 282
	i64 15609085926864131306, ; 610: System.dll => 0xd89e9cf3334914ea => 168
	i64 15661133872274321916, ; 611: System.Xml.ReaderWriter.dll => 0xd9578647d4bfb1fc => 160
	i64 15664356999916475676, ; 612: de/Microsoft.Maui.Controls.resources.dll => 0xd962f9b2b6ecd51c => 332
	i64 15710114879900314733, ; 613: Microsoft.Win32.Registry => 0xda058a3f5d096c6d => 9
	i64 15743187114543869802, ; 614: hu/Microsoft.Maui.Controls.resources.dll => 0xda7b09450ae4ef6a => 340
	i64 15750144475371186037, ; 615: Xamarin.AndroidX.Camera.View.dll => 0xda93c0f3d794a775 => 249
	i64 15755368083429170162, ; 616: System.IO.FileSystem.Primitives => 0xdaa64fcbde529bf2 => 53
	i64 15777549416145007739, ; 617: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 296
	i64 15783653065526199428, ; 618: el\Microsoft.Maui.Controls.resources => 0xdb0accd674b1c484 => 333
	i64 15817206913877585035, ; 619: System.Threading.Tasks.dll => 0xdb8201e29086ac8b => 148
	i64 15827202283623377193, ; 620: Microsoft.Extensions.Configuration.Json.dll => 0xdba5849eef9f6929 => 192
	i64 15847085070278954535, ; 621: System.Threading.Channels.dll => 0xdbec27e8f35f8e27 => 143
	i64 15852824340364052161, ; 622: Microsoft.AspNetCore.Http.Features.dll => 0xdc008bbee610c6c1 => 186
	i64 15885744048853936810, ; 623: System.Resources.Writer => 0xdc75800bd0b6eaaa => 104
	i64 15928521404965645318, ; 624: Microsoft.Maui.Controls.Compatibility => 0xdd0d79d32c2eec06 => 212
	i64 15930129725311349754, ; 625: Xamarin.GooglePlayServices.Tasks.dll => 0xdd1330956f12f3fa => 317
	i64 15934062614519587357, ; 626: System.Security.Cryptography.OpenSsl => 0xdd2129868f45a21d => 127
	i64 15937190497610202713, ; 627: System.Security.Cryptography.Cng => 0xdd2c465197c97e59 => 124
	i64 15963349826457351533, ; 628: System.Threading.Tasks.Extensions => 0xdd893616f748b56d => 146
	i64 15971679995444160383, ; 629: System.Formats.Tar.dll => 0xdda6ce5592a9677f => 43
	i64 16018552496348375205, ; 630: System.Net.NetworkInformation.dll => 0xde4d54a020caa8a5 => 72
	i64 16054465462676478687, ; 631: System.Globalization.Extensions => 0xdecceb47319bdadf => 45
	i64 16154507427712707110, ; 632: System => 0xe03056ea4e39aa26 => 168
	i64 16182611612321266217, ; 633: Microsoft.Maui.Maps => 0xe0942f85b2853a29 => 219
	i64 16219561732052121626, ; 634: System.Net.Security => 0xe1177575db7c781a => 77
	i64 16274182383641215830, ; 635: zxing.dll => 0xe1d982a752dac356 => 325
	i64 16288847719894691167, ; 636: nb\Microsoft.Maui.Controls.resources => 0xe20d9cb300c12d5f => 346
	i64 16315482530584035869, ; 637: WindowsBase.dll => 0xe26c3ceb1e8d821d => 169
	i64 16321164108206115771, ; 638: Microsoft.Extensions.Logging.Abstractions.dll => 0xe2806c487e7b0bbb => 205
	i64 16337011941688632206, ; 639: System.Security.Principal.Windows.dll => 0xe2b8b9cdc3aa638e => 131
	i64 16361933716545543812, ; 640: Xamarin.AndroidX.ExifInterface.dll => 0xe3114406a52f1e84 => 268
	i64 16423015068819898779, ; 641: Xamarin.Kotlin.StdLib.Jdk8 => 0xe3ea453135e5c19b => 322
	i64 16454459195343277943, ; 642: System.Net.NetworkInformation => 0xe459fb756d988f77 => 72
	i64 16496768397145114574, ; 643: Mono.Android.Export.dll => 0xe4f04b741db987ce => 173
	i64 16558262036769511634, ; 644: Microsoft.Extensions.Http => 0xe5cac397cf7b98d2 => 200
	i64 16589693266713801121, ; 645: Xamarin.AndroidX.Lifecycle.ViewModel.Ktx.dll => 0xe63a6e214f2a71a1 => 281
	i64 16621146507174665210, ; 646: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 255
	i64 16625379915503452982, ; 647: CLL.dll => 0xe6b936f2b77f4336 => 364
	i64 16648892297579399389, ; 648: CommunityToolkit.Mvvm => 0xe70cbf55c4f508dd => 181
	i64 16649148416072044166, ; 649: Microsoft.Maui.Graphics => 0xe70da84600bb4e86 => 218
	i64 16677317093839702854, ; 650: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 288
	i64 16690058410772333787, ; 651: PInvoke.Windows.Core => 0xe79effb2669b04db => 226
	i64 16702652415771857902, ; 652: System.ValueTuple => 0xe7cbbde0b0e6d3ee => 155
	i64 16709499819875633724, ; 653: System.IO.Compression.ZipFile => 0xe7e4118e32240a3c => 49
	i64 16737807731308835127, ; 654: System.Runtime.Intrinsics => 0xe848a3736f733137 => 112
	i64 16758309481308491337, ; 655: System.IO.FileSystem.DriveInfo => 0xe89179af15740e49 => 52
	i64 16762783179241323229, ; 656: System.Reflection.TypeExtensions => 0xe8a15e7d0d927add => 100
	i64 16765015072123548030, ; 657: System.Diagnostics.TextWriterTraceListener.dll => 0xe8a94c621bfe717e => 35
	i64 16822611501064131242, ; 658: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 27
	i64 16833383113903931215, ; 659: mscorlib => 0xe99c30c1484d7f4f => 170
	i64 16856067890322379635, ; 660: System.Data.Common.dll => 0xe9ecc87060889373 => 26
	i64 16885326587688996227, ; 661: ZXing.Net.MAUI.dll => 0xea54bb11b7a94d83 => 326
	i64 16890310621557459193, ; 662: System.Text.RegularExpressions.dll => 0xea66700587f088f9 => 142
	i64 16933958494752847024, ; 663: System.Net.WebProxy.dll => 0xeb018187f0f3b4b0 => 82
	i64 16942731696432749159, ; 664: sk\Microsoft.Maui.Controls.resources => 0xeb20acb622a01a67 => 353
	i64 16977952268158210142, ; 665: System.IO.Pipes.AccessControl => 0xeb9dcda2851b905e => 58
	i64 16989020923549080504, ; 666: Xamarin.AndroidX.Lifecycle.ViewModel.Ktx => 0xebc52084add25bb8 => 281
	i64 16998075588627545693, ; 667: Xamarin.AndroidX.Navigation.Fragment => 0xebe54bb02d623e5d => 286
	i64 17008137082415910100, ; 668: System.Collections.NonGeneric => 0xec090a90408c8cd4 => 14
	i64 17024911836938395553, ; 669: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 238
	i64 17027804579603049667, ; 670: Microsoft.Maui.Controls.Maps.dll => 0xec4eea0c48026cc3 => 214
	i64 17031351772568316411, ; 671: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 285
	i64 17037200463775726619, ; 672: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 272
	i64 17040771374769818752, ; 673: zxing => 0xec7cfb478bcccc80 => 325
	i64 17047433665992082296, ; 674: Microsoft.Extensions.Configuration.FileExtensions => 0xec94a699197e4378 => 191
	i64 17062143951396181894, ; 675: System.ComponentModel.Primitives => 0xecc8e986518c9786 => 20
	i64 17083811308454098714, ; 676: AppConfig => 0xed15e3df0235371a => 362
	i64 17089008752050867324, ; 677: zh-Hans/Microsoft.Maui.Controls.resources.dll => 0xed285aeb25888c7c => 360
	i64 17118171214553292978, ; 678: System.Threading.Channels => 0xed8ff6060fc420b2 => 143
	i64 17137864900836977098, ; 679: Microsoft.IdentityModel.Tokens => 0xedd5ed53b705e9ca => 211
	i64 17187273293601214786, ; 680: System.ComponentModel.Annotations.dll => 0xee8575ff9aa89142 => 17
	i64 17201328579425343169, ; 681: System.ComponentModel.EventBasedAsync => 0xeeb76534d96c16c1 => 19
	i64 17202182880784296190, ; 682: System.Security.Cryptography.Encoding.dll => 0xeeba6e30627428fe => 126
	i64 17205988430934219272, ; 683: Microsoft.Extensions.FileSystemGlobbing => 0xeec7f35113509a08 => 199
	i64 17230721278011714856, ; 684: System.Private.Xml.Linq => 0xef1fd1b5c7a72d28 => 91
	i64 17234219099804750107, ; 685: System.Transactions.Local.dll => 0xef2c3ef5e11d511b => 153
	i64 17260702271250283638, ; 686: System.Data.Common => 0xef8a5543bba6bc76 => 26
	i64 17306917412052548875, ; 687: ZXing.Net.MAUI => 0xf02e85b0b66a3d0b => 326
	i64 17333249706306540043, ; 688: System.Diagnostics.Tracing.dll => 0xf08c12c5bb8b920b => 38
	i64 17338386382517543202, ; 689: System.Net.WebSockets.Client.dll => 0xf09e528d5c6da122 => 83
	i64 17342750010158924305, ; 690: hi\Microsoft.Maui.Controls.resources => 0xf0add33f97ecc211 => 338
	i64 17360349973592121190, ; 691: Xamarin.Google.Crypto.Tink.Android => 0xf0ec5a52686b9f66 => 311
	i64 17438153253682247751, ; 692: sk/Microsoft.Maui.Controls.resources.dll => 0xf200c3fe308d7847 => 353
	i64 17449272605140165173, ; 693: BDO.dll => 0xf22844fbf255a235 => 363
	i64 17470386307322966175, ; 694: System.Threading.Timer => 0xf27347c8d0d5709f => 151
	i64 17509662556995089465, ; 695: System.Net.WebSockets.dll => 0xf2fed1534ea67439 => 84
	i64 17514990004910432069, ; 696: fr\Microsoft.Maui.Controls.resources => 0xf311be9c6f341f45 => 336
	i64 17522591619082469157, ; 697: GoogleGson => 0xf32cc03d27a5bf25 => 182
	i64 17590473451926037903, ; 698: Xamarin.Android.Glide => 0xf41dea67fcfda58f => 231
	i64 17593636555046515727, ; 699: PInvoke.BCrypt => 0xf429273b52dff40f => 223
	i64 17623389608345532001, ; 700: pl\Microsoft.Maui.Controls.resources => 0xf492db79dfbef661 => 348
	i64 17627500474728259406, ; 701: System.Globalization => 0xf4a176498a351f4e => 46
	i64 17685921127322830888, ; 702: System.Diagnostics.Debug.dll => 0xf571038fafa74828 => 30
	i64 17702523067201099846, ; 703: zh-HK/Microsoft.Maui.Controls.resources.dll => 0xf5abfef008ae1846 => 359
	i64 17704177640604968747, ; 704: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 283
	i64 17710060891934109755, ; 705: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 280
	i64 17712670374920797664, ; 706: System.Runtime.InteropServices.dll => 0xf5d00bdc38bd3de0 => 111
	i64 17777860260071588075, ; 707: System.Runtime.Numerics.dll => 0xf6b7a5b72419c0eb => 114
	i64 17790600151040787804, ; 708: Microsoft.IdentityModel.Logging => 0xf6e4e89427cc055c => 210
	i64 17838668724098252521, ; 709: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 11
	i64 17891337867145587222, ; 710: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 318
	i64 17910264068556501837, ; 711: Microsoft.Extensions.Identity.Core => 0xf88e0a4717c0b34d => 201
	i64 17928294245072900555, ; 712: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 48
	i64 17969331831154222830, ; 713: Xamarin.GooglePlayServices.Maps => 0xf95fe418471126ee => 316
	i64 17986907704309214542, ; 714: Xamarin.GooglePlayServices.Basement.dll => 0xf99e554223166d4e => 315
	i64 17992315986609351877, ; 715: System.Xml.XmlDocument.dll => 0xf9b18c0ffc6eacc5 => 165
	i64 18017743553296241350, ; 716: Microsoft.Extensions.Caching.Abstractions => 0xfa0be24cb44e92c6 => 187
	i64 18025913125965088385, ; 717: System.Threading => 0xfa28e87b91334681 => 152
	i64 18099568558057551825, ; 718: nl/Microsoft.Maui.Controls.resources.dll => 0xfb2e95b53ad977d1 => 347
	i64 18116111925905154859, ; 719: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 243
	i64 18121036031235206392, ; 720: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 285
	i64 18146411883821974900, ; 721: System.Formats.Asn1.dll => 0xfbd50176eb22c574 => 42
	i64 18146811631844267958, ; 722: System.ComponentModel.EventBasedAsync.dll => 0xfbd66d08820117b6 => 19
	i64 18225059387460068507, ; 723: System.Threading.ThreadPool.dll => 0xfcec6af3cff4a49b => 150
	i64 18245806341561545090, ; 724: System.Collections.Concurrent.dll => 0xfd3620327d587182 => 12
	i64 18260797123374478311, ; 725: Xamarin.AndroidX.Emoji2 => 0xfd6b623bde35f3e7 => 266
	i64 18305135509493619199, ; 726: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 287
	i64 18318849532986632368, ; 727: System.Security.dll => 0xfe39a097c37fa8b0 => 134
	i64 18324163916253801303, ; 728: it\Microsoft.Maui.Controls.resources => 0xfe4c81ff0a56ab57 => 342
	i64 18335459783622540540, ; 729: ZXing.Net.MAUI.Controls => 0xfe74a3871c483cfc => 327
	i64 18380184030268848184, ; 730: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 303
	i64 18439108438687598470 ; 731: System.Reflection.Metadata.dll => 0xffe4df6e2ee1c786 => 98
], align 16

@assembly_image_cache_indices = dso_local local_unnamed_addr constant [732 x i32] [
	i32 265, ; 0
	i32 209, ; 1
	i32 175, ; 2
	i32 217, ; 3
	i32 62, ; 4
	i32 251, ; 5
	i32 155, ; 6
	i32 293, ; 7
	i32 252, ; 8
	i32 296, ; 9
	i32 259, ; 10
	i32 136, ; 11
	i32 208, ; 12
	i32 60, ; 13
	i32 295, ; 14
	i32 335, ; 15
	i32 99, ; 16
	i32 219, ; 17
	i32 278, ; 18
	i32 191, ; 19
	i32 133, ; 20
	i32 190, ; 21
	i32 314, ; 22
	i32 228, ; 23
	i32 149, ; 24
	i32 253, ; 25
	i32 22, ; 26
	i32 338, ; 27
	i32 264, ; 28
	i32 183, ; 29
	i32 279, ; 30
	i32 154, ; 31
	i32 108, ; 32
	i32 99, ; 33
	i32 308, ; 34
	i32 346, ; 35
	i32 40, ; 36
	i32 230, ; 37
	i32 32, ; 38
	i32 242, ; 39
	i32 286, ; 40
	i32 54, ; 41
	i32 119, ; 42
	i32 74, ; 43
	i32 213, ; 44
	i32 309, ; 45
	i32 69, ; 46
	i32 174, ; 47
	i32 149, ; 48
	i32 344, ; 49
	i32 307, ; 50
	i32 1, ; 51
	i32 241, ; 52
	i32 282, ; 53
	i32 272, ; 54
	i32 184, ; 55
	i32 44, ; 56
	i32 93, ; 57
	i32 85, ; 58
	i32 221, ; 59
	i32 70, ; 60
	i32 66, ; 61
	i32 90, ; 62
	i32 240, ; 63
	i32 110, ; 64
	i32 334, ; 65
	i32 293, ; 66
	i32 106, ; 67
	i32 39, ; 68
	i32 237, ; 69
	i32 356, ; 70
	i32 295, ; 71
	i32 215, ; 72
	i32 181, ; 73
	i32 356, ; 74
	i32 123, ; 75
	i32 280, ; 76
	i32 330, ; 77
	i32 348, ; 78
	i32 146, ; 79
	i32 145, ; 80
	i32 321, ; 81
	i32 57, ; 82
	i32 39, ; 83
	i32 145, ; 84
	i32 221, ; 85
	i32 246, ; 86
	i32 234, ; 87
	i32 245, ; 88
	i32 223, ; 89
	i32 206, ; 90
	i32 264, ; 91
	i32 12, ; 92
	i32 18, ; 93
	i32 352, ; 94
	i32 292, ; 95
	i32 55, ; 96
	i32 275, ; 97
	i32 140, ; 98
	i32 105, ; 99
	i32 257, ; 100
	i32 302, ; 101
	i32 120, ; 102
	i32 235, ; 103
	i32 167, ; 104
	i32 355, ; 105
	i32 211, ; 106
	i32 170, ; 107
	i32 71, ; 108
	i32 193, ; 109
	i32 330, ; 110
	i32 84, ; 111
	i32 362, ; 112
	i32 105, ; 113
	i32 297, ; 114
	i32 121, ; 115
	i32 335, ; 116
	i32 310, ; 117
	i32 82, ; 118
	i32 308, ; 119
	i32 1, ; 120
	i32 118, ; 121
	i32 125, ; 122
	i32 52, ; 123
	i32 132, ; 124
	i32 273, ; 125
	i32 238, ; 126
	i32 86, ; 127
	i32 114, ; 128
	i32 79, ; 129
	i32 324, ; 130
	i32 197, ; 131
	i32 315, ; 132
	i32 217, ; 133
	i32 57, ; 134
	i32 299, ; 135
	i32 188, ; 136
	i32 73, ; 137
	i32 298, ; 138
	i32 87, ; 139
	i32 176, ; 140
	i32 350, ; 141
	i32 120, ; 142
	i32 189, ; 143
	i32 160, ; 144
	i32 188, ; 145
	i32 232, ; 146
	i32 3, ; 147
	i32 171, ; 148
	i32 291, ; 149
	i32 265, ; 150
	i32 204, ; 151
	i32 36, ; 152
	i32 198, ; 153
	i32 215, ; 154
	i32 225, ; 155
	i32 227, ; 156
	i32 126, ; 157
	i32 76, ; 158
	i32 66, ; 159
	i32 165, ; 160
	i32 117, ; 161
	i32 364, ; 162
	i32 92, ; 163
	i32 212, ; 164
	i32 361, ; 165
	i32 109, ; 166
	i32 22, ; 167
	i32 150, ; 168
	i32 122, ; 169
	i32 62, ; 170
	i32 259, ; 171
	i32 2, ; 172
	i32 21, ; 173
	i32 56, ; 174
	i32 317, ; 175
	i32 96, ; 176
	i32 244, ; 177
	i32 358, ; 178
	i32 59, ; 179
	i32 133, ; 180
	i32 156, ; 181
	i32 45, ; 182
	i32 96, ; 183
	i32 303, ; 184
	i32 200, ; 185
	i32 224, ; 186
	i32 54, ; 187
	i32 328, ; 188
	i32 166, ; 189
	i32 248, ; 190
	i32 17, ; 191
	i32 277, ; 192
	i32 180, ; 193
	i32 235, ; 194
	i32 298, ; 195
	i32 40, ; 196
	i32 71, ; 197
	i32 113, ; 198
	i32 236, ; 199
	i32 103, ; 200
	i32 103, ; 201
	i32 15, ; 202
	i32 15, ; 203
	i32 284, ; 204
	i32 29, ; 205
	i32 132, ; 206
	i32 80, ; 207
	i32 276, ; 208
	i32 113, ; 209
	i32 302, ; 210
	i32 222, ; 211
	i32 300, ; 212
	i32 110, ; 213
	i32 6, ; 214
	i32 30, ; 215
	i32 255, ; 216
	i32 161, ; 217
	i32 354, ; 218
	i32 25, ; 219
	i32 357, ; 220
	i32 53, ; 221
	i32 47, ; 222
	i32 130, ; 223
	i32 214, ; 224
	i32 239, ; 225
	i32 63, ; 226
	i32 123, ; 227
	i32 305, ; 228
	i32 268, ; 229
	i32 203, ; 230
	i32 254, ; 231
	i32 7, ; 232
	i32 274, ; 233
	i32 294, ; 234
	i32 42, ; 235
	i32 128, ; 236
	i32 195, ; 237
	i32 351, ; 238
	i32 294, ; 239
	i32 351, ; 240
	i32 141, ; 241
	i32 153, ; 242
	i32 89, ; 243
	i32 94, ; 244
	i32 278, ; 245
	i32 365, ; 246
	i32 275, ; 247
	i32 339, ; 248
	i32 245, ; 249
	i32 261, ; 250
	i32 306, ; 251
	i32 207, ; 252
	i32 312, ; 253
	i32 276, ; 254
	i32 137, ; 255
	i32 100, ; 256
	i32 7, ; 257
	i32 347, ; 258
	i32 109, ; 259
	i32 350, ; 260
	i32 37, ; 261
	i32 158, ; 262
	i32 162, ; 263
	i32 159, ; 264
	i32 86, ; 265
	i32 327, ; 266
	i32 270, ; 267
	i32 147, ; 268
	i32 91, ; 269
	i32 23, ; 270
	i32 271, ; 271
	i32 55, ; 272
	i32 316, ; 273
	i32 234, ; 274
	i32 354, ; 275
	i32 220, ; 276
	i32 65, ; 277
	i32 58, ; 278
	i32 8, ; 279
	i32 101, ; 280
	i32 233, ; 281
	i32 21, ; 282
	i32 4, ; 283
	i32 159, ; 284
	i32 88, ; 285
	i32 33, ; 286
	i32 49, ; 287
	i32 68, ; 288
	i32 70, ; 289
	i32 345, ; 290
	i32 176, ; 291
	i32 279, ; 292
	i32 5, ; 293
	i32 319, ; 294
	i32 309, ; 295
	i32 51, ; 296
	i32 28, ; 297
	i32 230, ; 298
	i32 241, ; 299
	i32 196, ; 300
	i32 187, ; 301
	i32 169, ; 302
	i32 112, ; 303
	i32 16, ; 304
	i32 273, ; 305
	i32 67, ; 306
	i32 31, ; 307
	i32 27, ; 308
	i32 97, ; 309
	i32 172, ; 310
	i32 16, ; 311
	i32 323, ; 312
	i32 0, ; 313
	i32 218, ; 314
	i32 33, ; 315
	i32 107, ; 316
	i32 220, ; 317
	i32 18, ; 318
	i32 249, ; 319
	i32 130, ; 320
	i32 256, ; 321
	i32 288, ; 322
	i32 95, ; 323
	i32 277, ; 324
	i32 185, ; 325
	i32 202, ; 326
	i32 13, ; 327
	i32 90, ; 328
	i32 267, ; 329
	i32 178, ; 330
	i32 300, ; 331
	i32 349, ; 332
	i32 75, ; 333
	i32 172, ; 334
	i32 247, ; 335
	i32 5, ; 336
	i32 287, ; 337
	i32 9, ; 338
	i32 349, ; 339
	i32 48, ; 340
	i32 0, ; 341
	i32 31, ; 342
	i32 195, ; 343
	i32 320, ; 344
	i32 162, ; 345
	i32 290, ; 346
	i32 116, ; 347
	i32 359, ; 348
	i32 247, ; 349
	i32 125, ; 350
	i32 305, ; 351
	i32 240, ; 352
	i32 210, ; 353
	i32 163, ; 354
	i32 185, ; 355
	i32 135, ; 356
	i32 311, ; 357
	i32 61, ; 358
	i32 227, ; 359
	i32 192, ; 360
	i32 142, ; 361
	i32 87, ; 362
	i32 34, ; 363
	i32 257, ; 364
	i32 14, ; 365
	i32 307, ; 366
	i32 175, ; 367
	i32 254, ; 368
	i32 154, ; 369
	i32 98, ; 370
	i32 184, ; 371
	i32 314, ; 372
	i32 267, ; 373
	i32 64, ; 374
	i32 216, ; 375
	i32 161, ; 376
	i32 334, ; 377
	i32 206, ; 378
	i32 68, ; 379
	i32 92, ; 380
	i32 83, ; 381
	i32 51, ; 382
	i32 213, ; 383
	i32 147, ; 384
	i32 331, ; 385
	i32 190, ; 386
	i32 321, ; 387
	i32 261, ; 388
	i32 78, ; 389
	i32 95, ; 390
	i32 180, ; 391
	i32 244, ; 392
	i32 318, ; 393
	i32 139, ; 394
	i32 94, ; 395
	i32 299, ; 396
	i32 324, ; 397
	i32 258, ; 398
	i32 329, ; 399
	i32 226, ; 400
	i32 116, ; 401
	i32 46, ; 402
	i32 163, ; 403
	i32 183, ; 404
	i32 8, ; 405
	i32 107, ; 406
	i32 74, ; 407
	i32 208, ; 408
	i32 64, ; 409
	i32 43, ; 410
	i32 242, ; 411
	i32 178, ; 412
	i32 157, ; 413
	i32 60, ; 414
	i32 38, ; 415
	i32 205, ; 416
	i32 216, ; 417
	i32 239, ; 418
	i32 25, ; 419
	i32 167, ; 420
	i32 186, ; 421
	i32 312, ; 422
	i32 340, ; 423
	i32 310, ; 424
	i32 304, ; 425
	i32 144, ; 426
	i32 343, ; 427
	i32 207, ; 428
	i32 93, ; 429
	i32 252, ; 430
	i32 2, ; 431
	i32 151, ; 432
	i32 260, ; 433
	i32 166, ; 434
	i32 289, ; 435
	i32 10, ; 436
	i32 173, ; 437
	i32 35, ; 438
	i32 111, ; 439
	i32 270, ; 440
	i32 229, ; 441
	i32 341, ; 442
	i32 304, ; 443
	i32 204, ; 444
	i32 237, ; 445
	i32 297, ; 446
	i32 201, ; 447
	i32 171, ; 448
	i32 202, ; 449
	i32 271, ; 450
	i32 144, ; 451
	i32 337, ; 452
	i32 63, ; 453
	i32 148, ; 454
	i32 177, ; 455
	i32 85, ; 456
	i32 78, ; 457
	i32 198, ; 458
	i32 199, ; 459
	i32 134, ; 460
	i32 29, ; 461
	i32 11, ; 462
	i32 97, ; 463
	i32 301, ; 464
	i32 141, ; 465
	i32 231, ; 466
	i32 117, ; 467
	i32 13, ; 468
	i32 229, ; 469
	i32 108, ; 470
	i32 179, ; 471
	i32 23, ; 472
	i32 269, ; 473
	i32 283, ; 474
	i32 365, ; 475
	i32 263, ; 476
	i32 37, ; 477
	i32 250, ; 478
	i32 50, ; 479
	i32 225, ; 480
	i32 222, ; 481
	i32 342, ; 482
	i32 34, ; 483
	i32 251, ; 484
	i32 61, ; 485
	i32 138, ; 486
	i32 118, ; 487
	i32 306, ; 488
	i32 248, ; 489
	i32 363, ; 490
	i32 355, ; 491
	i32 322, ; 492
	i32 59, ; 493
	i32 209, ; 494
	i32 10, ; 495
	i32 81, ; 496
	i32 228, ; 497
	i32 262, ; 498
	i32 4, ; 499
	i32 3, ; 500
	i32 177, ; 501
	i32 115, ; 502
	i32 266, ; 503
	i32 106, ; 504
	i32 329, ; 505
	i32 343, ; 506
	i32 174, ; 507
	i32 119, ; 508
	i32 337, ; 509
	i32 301, ; 510
	i32 256, ; 511
	i32 80, ; 512
	i32 313, ; 513
	i32 89, ; 514
	i32 319, ; 515
	i32 357, ; 516
	i32 243, ; 517
	i32 358, ; 518
	i32 341, ; 519
	i32 197, ; 520
	i32 291, ; 521
	i32 164, ; 522
	i32 6, ; 523
	i32 262, ; 524
	i32 28, ; 525
	i32 236, ; 526
	i32 36, ; 527
	i32 121, ; 528
	i32 41, ; 529
	i32 20, ; 530
	i32 336, ; 531
	i32 56, ; 532
	i32 339, ; 533
	i32 320, ; 534
	i32 24, ; 535
	i32 127, ; 536
	i32 158, ; 537
	i32 269, ; 538
	i32 135, ; 539
	i32 331, ; 540
	i32 250, ; 541
	i32 152, ; 542
	i32 232, ; 543
	i32 124, ; 544
	i32 32, ; 545
	i32 136, ; 546
	i32 104, ; 547
	i32 138, ; 548
	i32 289, ; 549
	i32 157, ; 550
	i32 246, ; 551
	i32 101, ; 552
	i32 129, ; 553
	i32 233, ; 554
	i32 73, ; 555
	i32 76, ; 556
	i32 352, ; 557
	i32 274, ; 558
	i32 292, ; 559
	i32 333, ; 560
	i32 140, ; 561
	i32 179, ; 562
	i32 128, ; 563
	i32 75, ; 564
	i32 115, ; 565
	i32 284, ; 566
	i32 193, ; 567
	i32 156, ; 568
	i32 344, ; 569
	i32 360, ; 570
	i32 313, ; 571
	i32 122, ; 572
	i32 260, ; 573
	i32 182, ; 574
	i32 361, ; 575
	i32 328, ; 576
	i32 131, ; 577
	i32 137, ; 578
	i32 194, ; 579
	i32 81, ; 580
	i32 50, ; 581
	i32 263, ; 582
	i32 77, ; 583
	i32 67, ; 584
	i32 196, ; 585
	i32 102, ; 586
	i32 88, ; 587
	i32 224, ; 588
	i32 345, ; 589
	i32 47, ; 590
	i32 65, ; 591
	i32 290, ; 592
	i32 189, ; 593
	i32 41, ; 594
	i32 44, ; 595
	i32 253, ; 596
	i32 323, ; 597
	i32 164, ; 598
	i32 102, ; 599
	i32 203, ; 600
	i32 258, ; 601
	i32 194, ; 602
	i32 139, ; 603
	i32 24, ; 604
	i32 69, ; 605
	i32 332, ; 606
	i32 129, ; 607
	i32 79, ; 608
	i32 282, ; 609
	i32 168, ; 610
	i32 160, ; 611
	i32 332, ; 612
	i32 9, ; 613
	i32 340, ; 614
	i32 249, ; 615
	i32 53, ; 616
	i32 296, ; 617
	i32 333, ; 618
	i32 148, ; 619
	i32 192, ; 620
	i32 143, ; 621
	i32 186, ; 622
	i32 104, ; 623
	i32 212, ; 624
	i32 317, ; 625
	i32 127, ; 626
	i32 124, ; 627
	i32 146, ; 628
	i32 43, ; 629
	i32 72, ; 630
	i32 45, ; 631
	i32 168, ; 632
	i32 219, ; 633
	i32 77, ; 634
	i32 325, ; 635
	i32 346, ; 636
	i32 169, ; 637
	i32 205, ; 638
	i32 131, ; 639
	i32 268, ; 640
	i32 322, ; 641
	i32 72, ; 642
	i32 173, ; 643
	i32 200, ; 644
	i32 281, ; 645
	i32 255, ; 646
	i32 364, ; 647
	i32 181, ; 648
	i32 218, ; 649
	i32 288, ; 650
	i32 226, ; 651
	i32 155, ; 652
	i32 49, ; 653
	i32 112, ; 654
	i32 52, ; 655
	i32 100, ; 656
	i32 35, ; 657
	i32 27, ; 658
	i32 170, ; 659
	i32 26, ; 660
	i32 326, ; 661
	i32 142, ; 662
	i32 82, ; 663
	i32 353, ; 664
	i32 58, ; 665
	i32 281, ; 666
	i32 286, ; 667
	i32 14, ; 668
	i32 238, ; 669
	i32 214, ; 670
	i32 285, ; 671
	i32 272, ; 672
	i32 325, ; 673
	i32 191, ; 674
	i32 20, ; 675
	i32 362, ; 676
	i32 360, ; 677
	i32 143, ; 678
	i32 211, ; 679
	i32 17, ; 680
	i32 19, ; 681
	i32 126, ; 682
	i32 199, ; 683
	i32 91, ; 684
	i32 153, ; 685
	i32 26, ; 686
	i32 326, ; 687
	i32 38, ; 688
	i32 83, ; 689
	i32 338, ; 690
	i32 311, ; 691
	i32 353, ; 692
	i32 363, ; 693
	i32 151, ; 694
	i32 84, ; 695
	i32 336, ; 696
	i32 182, ; 697
	i32 231, ; 698
	i32 223, ; 699
	i32 348, ; 700
	i32 46, ; 701
	i32 30, ; 702
	i32 359, ; 703
	i32 283, ; 704
	i32 280, ; 705
	i32 111, ; 706
	i32 114, ; 707
	i32 210, ; 708
	i32 11, ; 709
	i32 318, ; 710
	i32 201, ; 711
	i32 48, ; 712
	i32 316, ; 713
	i32 315, ; 714
	i32 165, ; 715
	i32 187, ; 716
	i32 152, ; 717
	i32 347, ; 718
	i32 243, ; 719
	i32 285, ; 720
	i32 42, ; 721
	i32 19, ; 722
	i32 150, ; 723
	i32 12, ; 724
	i32 266, ; 725
	i32 287, ; 726
	i32 134, ; 727
	i32 342, ; 728
	i32 327, ; 729
	i32 303, ; 730
	i32 98 ; 731
], align 16

@marshal_methods_number_of_classes = dso_local local_unnamed_addr constant i32 0, align 4

@marshal_methods_class_cache = dso_local local_unnamed_addr global [0 x %struct.MarshalMethodsManagedClass] zeroinitializer, align 8

; Names of classes in which marshal methods reside
@mm_class_names = dso_local local_unnamed_addr constant [0 x ptr] zeroinitializer, align 8

@mm_method_names = dso_local local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		ptr @.MarshalMethodName.0_name; char* name
	} ; 0
], align 8

; get_function_pointer (uint32_t mono_image_index, uint32_t class_index, uint32_t method_token, void*& target_ptr)
@get_function_pointer = internal dso_local unnamed_addr global ptr null, align 8

; Functions

; Function attributes: "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" uwtable willreturn
define void @xamarin_app_init(ptr nocapture noundef readnone %env, ptr noundef %fn) local_unnamed_addr #0
{
	%fnIsNull = icmp eq ptr %fn, null
	br i1 %fnIsNull, label %1, label %2

1: ; preds = %0
	%putsResult = call noundef i32 @puts(ptr @.str.0)
	call void @abort()
	unreachable 

2: ; preds = %1, %0
	store ptr %fn, ptr @get_function_pointer, align 8, !tbaa !3
	ret void
}

; Strings
@.str.0 = private unnamed_addr constant [40 x i8] c"get_function_pointer MUST be specified\0A\00", align 16

;MarshalMethodName
@.MarshalMethodName.0_name = private unnamed_addr constant [1 x i8] c"\00", align 1

; External functions

; Function attributes: noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8"
declare void @abort() local_unnamed_addr #2

; Function attributes: nofree nounwind
declare noundef i32 @puts(ptr noundef) local_unnamed_addr #1
attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+crc32,+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn }
attributes #1 = { nofree nounwind }
attributes #2 = { noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+crc32,+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }

; Metadata
!llvm.module.flags = !{!0, !1}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!llvm.ident = !{!2}
!2 = !{!"Xamarin.Android remotes/origin/release/8.0.2xx @ 96b6bb65e8736e45180905177aa343f0e1854ea3"}
!3 = !{!4, !4, i64 0}
!4 = !{!"any pointer", !5, i64 0}
!5 = !{!"omnipotent char", !6, i64 0}
!6 = !{!"Simple C++ TBAA"}
