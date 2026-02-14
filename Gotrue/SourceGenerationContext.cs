using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using Supabase.Gotrue.Mfa;
using Supabase.Gotrue.Responses;

namespace Supabase.Gotrue
{
	[JsonSourceGenerationOptions(WriteIndented = false)]
	[JsonSerializable(typeof(Factor))]
	[JsonSerializable(typeof(MfaChallengeResponse))]
	[JsonSerializable(typeof(MfaEnrollResponse))]
	[JsonSerializable(typeof(MfaUnenrollResponse))]
	[JsonSerializable(typeof(MfaVerifyResponse))]
	[JsonSerializable(typeof(TOTP))]
	[JsonSerializable(typeof(BaseResponse))]
	[JsonSerializable(typeof(GenerateLinkResponse))]
	[JsonSerializable(typeof(GenerateLinkOptions))]
	[JsonSerializable(typeof(Session))]
	[JsonSerializable(typeof(Settings))]
	[JsonSerializable(typeof(SignInAnonymouslyOptions))]
	[JsonSerializable(typeof(SignInWithSSOOptions))]
	[JsonSerializable(typeof(Settings))]
	[JsonSerializable(typeof(AmrEntry))]
    [JsonSerializable(typeof(UserAttributes))]
	public partial class SourceGenerationContext : JsonSerializerContext
	{
		public static SourceGenerationContext Instance { get; } = new(new JsonSerializerOptions
		{
			Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
			WriteIndented = false
		});
	}
}