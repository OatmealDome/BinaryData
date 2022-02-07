# OatmealDome's BinaryData Fork

This is a fork of Syroot.BinaryData on version 4.0.4.

A bunch of libraries and programs (for example, Switch Toolbox) use other libraries originally made by Syroot which in turn use BinaryData, and they are very particular about which BinaryData version they use. This complicates things I write which use my preferred BinaryData version in separate parts of the code. Because of this, I decided to fork 4.0.4 so I can change the namespace and version to avoid conflicts.

I also personally dislike the changes made in version 5.0.0+ of the library, and much prefer to use the APIs in 4.0.0.

If you're looking to use Syroot.BinaryData, I recommend you take a look at [the latest version](https://www.nuget.org/packages/Syroot.BinaryData/) and use that instead. This fork is really just for my personal purposes.

# Original Readme

When parsing or storing data in binary file formats, the functionality offered by the default .NET `BinaryReader` and
`BinaryWriter` classes is often insufficient. It lacks support for a different byte order than the system one, and
cannot parse specific string or date formats (most prominently, 0-terminated strings instead of the default
variable-length prefixed .NET strings).

Further, navigating in binary files is slightly tedious when it is required to skip to another chunk in the file and
then navigate back. Also, aligning to specific block sizes might be a common task.

This NuGet package adds all this and more functionality by offering a large set of extension methods for the `Stream`
class of .NET 4.5 and .NET Standard 2.0. Additionally, serializing and deserializing complete class hierarchies can be
done immediately.
Additionally, `BinaryDataReader` and `BinaryDataWriter` classes are provided, usable like the default .NET
`BinaryReader` and `BinaryWriter` so that new functionality can be added almost instantly to existing projects.

## Installation

The library is available in the following NuGet packages:

- [Syroot.IO.BinaryData](https://www.nuget.org/packages/Syroot.IO.BinaryData) (unsigned)
- [Syroot.IO.BinaryData.Signed](https://www.nuget.org/packages/Syroot.IO.BinaryData.Signed) (signed assembly)

### Are you using 3.x.x or earlier?
If you used object serialization features, you **want to update to 4.x.x**:
- Members in pre-4.x.x versions were not read or written in a deterministic order.
- 4.x.x fixes this by serializing members alphabetically or with the given order specified through the new `BinaryMemberAttribute.Order` property.
Please consult the [wiki page](https://github.com/Syroot/BinaryData/wiki/Object-Values#ordering-members) for guidance.

## Documentation

- A code-oriented feature tour is available [on the wiki](https://github.com/Syroot/BinaryData/wiki).
- Complete MSDN-style API documentation is hosted on [docs.syroot.com](http://docs.syroot.com/binarydata).

## Support

You can ask questions and suggest features on Discord aswell. Feel free to [join the BinaryData channel on the Syroot server](https://discord.gg/KSaSWTV)!
