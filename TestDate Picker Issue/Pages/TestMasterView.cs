using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Date_Picker_Issue.Pages;
using Date_Picker_Issue.MovieApp;

namespace TestDate_Picker_Issue
{
	public class TestMasterView
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbTabsModule),
				typeof(IgbCardModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule),
				typeof(IgbDatePickerModule),
				typeof(IgbListModule),
				typeof(IgbAvatarModule));
			ctx.Services.AddScoped<IMovieAppService>(sp => new MockMovieAppService());
			var componentUnderTest = ctx.RenderComponent<MasterView>();
			Assert.NotNull(componentUnderTest);
		}
	}
}