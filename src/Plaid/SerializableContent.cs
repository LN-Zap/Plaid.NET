using Newtonsoft.Json;

namespace Acklann.Plaid
{
	/// <summary>
	/// Provide an method for converting an object to a JSON string.
	/// </summary>
	public abstract class SerializableContent
	{
		private static readonly JsonSerializerSettings _ignoreNullSerializerSettings = new JsonSerializerSettings() {
			DateFormatString = "yyyy-MM-dd",
			NullValueHandling = NullValueHandling.Ignore,
#if DEBUG
			Formatting = Formatting.Indented
#else
			Formatting = Formatting.None
#endif
		};

		private static readonly JsonSerializerSettings _includeNullSerializerSettings = new JsonSerializerSettings() {
			DateFormatString = "yyyy-MM-dd",
			NullValueHandling = NullValueHandling.Include,
#if DEBUG
			Formatting = Formatting.Indented
#else
			Formatting = Formatting.None
#endif
		};

		/// <summary>
		/// The null value handling.
		/// </summary>
		protected bool HandleNullValue = false;

		/// <summary>
		/// Returns a string that represents the current object in JSON format.
		/// </summary>
		/// <returns>System.String.</returns>
		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, HandleNullValue ? _ignoreNullSerializerSettings : _includeNullSerializerSettings);
		}
	}
}
