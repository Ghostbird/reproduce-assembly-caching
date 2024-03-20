# Reproduction of seeming assembly caching in MAUI build

This demonstrates an apparent bug in the MAUI build process. See [dotnet/maui#21302](https://github.com/dotnet/maui/issues/21302).

However @rolfbjarne pointed out that the logic `BeforeTargets="Build"` is not correct, and the appropriate target is `BeforeTargets="ResolveAssemblyReferences"`. It is an implementation detail that `BeforeTargets="Build"` works in the vanilla `dotnet build` process. You can see that fix demonstrated on the `fix` branch.
