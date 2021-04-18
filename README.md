# NET Core 3.1 Speed test (Solution 1 of 2)

Just a very small and simple speed test to see how .NET Core performs while executing some string operations and such. This solution only contains the NET Core project. I decided to create two distinct projects to separate Core and Framework and is more of a preference than a necessity. Check out BenchmarkDotNet NuGet package for more information about that.

**Disclaimer**:
- Not a full comparison between core and framework obviously!
- Results may differ depending on PC setup and such.


# Purpose

Compare (to some extent) the results between NET Core and NET Framework.
# Tools

I used a very handy NuGet package called BenchmarkDotNet to setup the test according to my needs. If you are interested in doing similar experiments, I highly recommend checking it out.

# Results

This little experiment showed that .NET Core is a bit faster when it comes to Sha256.
The Sha256 method is not included in this version of the project but looks something like this : public byte[] Sha256() => sha256.ComputeHash(data);

