﻿using NUnit.Framework;

namespace VkNet.Tests.Categories
{
	[TestFixture]
	public class StorageCategoryTests : BaseTest
	{
		[Test]
		public void Get()
		{
			Json = @"
            {
				""response"": [{
					""key"": ""qwe"",
					""value"": ""qwe""
				}]
			}";

			Url = "https://api.vk.com/method/storage.get";
			var result = Api.Storage.Get(keys: new[] { "qwe" });
			Assert.NotNull(anObject: result);
			Assert.IsNotEmpty(collection: result);
		}

		[Test]
		public void GetKeys()
		{
			Json = @"
            {
				""response"": [""qwe"", ""qwe1""]
			}";

			Url = "https://api.vk.com/method/storage.getKeys";
			var result = Api.Storage.GetKeys();
			Assert.NotNull(anObject: result);
			Assert.IsNotEmpty(collection: result);
		}

		[Test]
		public void Set()
		{
			Json = @"
            {
				'response': 1
			}";

			Url = "https://api.vk.com/method/storage.set";
			var result = Api.Storage.Set(key: "qwe", value: "qwe");
			Assert.True(condition: result);
		}
	}
}