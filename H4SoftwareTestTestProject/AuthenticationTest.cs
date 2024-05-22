using Bunit;
using Bunit.TestDoubles;
using H4SoftwareTest.Components.Pages;
using System.Drawing.Text;

namespace H4SoftwareTestTestProject;

public class AuthenticationTest
{

    [Fact]
    public void AuthenticationView_NotLoggedIn()
    {
        //Arange
        var ctx = new TestContext();
        var authContext = ctx.AddTestAuthorization();

        //Act
        var cut = ctx.RenderComponent<Home>();

        //Assert
        cut.MarkupMatches("<div><h1>You must log in to see the content.</h1></div><br/>");
    }

    [Fact]
    public void AuthenticationView_LoggedIn()
    {
        //Arange
        var ctx = new TestContext();
        var authContext = ctx.AddTestAuthorization();
        authContext.SetAuthorized("");

        //Act
        var cut = ctx.RenderComponent<Home>();
        var homeObj = cut.Instance;


        //Assert
        if (homeObj._isAdmin)
        {
            cut.MarkupMatches("<h1>Hello, world!</h1><h2>You are admin</h2><br/>");
        }
        else
        {
            cut.MarkupMatches("<h1>Hello, world!</h1><h2>You are NOT admin</h2><br/>");
        }
    }

    [Fact]
    public void UserNotLoggedIn()
    {
        //Arrange
        var ctx = new TestContext();
        var authContext = ctx.AddTestAuthorization();

        //Act
        var cut = ctx.RenderComponent<Home>();
        var homeObj = cut.Instance;

        //Assert
        Assert.False(homeObj._isAuthenticated);
    }

    [Fact]
    public void UserLoggedIn()
    {
        //Arrange
        var ctx = new TestContext();
        var authContext = ctx.AddTestAuthorization();
        authContext.SetAuthorized("");

        //Act
        var cut = ctx.RenderComponent<Home>();
        var homeObj = cut.Instance;

        //Assert
        Assert.True(homeObj._isAuthenticated);
    }
}