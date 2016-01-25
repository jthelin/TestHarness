# TestHarness

A simple wrapper application for running single Visual Studio test methods directly in .exe for easier debugger single-stepping.

[https://github.com/jthelin/TestHarness](https://github.com/jthelin/TestHarness)


## Components

The `DebugTestHarness` project contains some program code to set up a test class in roughly the same way that the MsTest framework would, and then runs the specified test case method.

Callbacks steps made to the test class in order are:

1. `ClassInitialize` method called. (static)
2. Class constructor called.
3. Set `TestContext` property to an instance of `MockTestContext`
4. `TestInitisalize` method called.
5. Run specific test method (in this example, `TestMethod1`)
6. `TestCleanup` method called.
7. Finally: `ClassCleanup` method called. (static)

## License

Apache 2.0
