﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace NonAsciiValidations.Tests
{
	public class ParsersYamlFilesTestData : FilesTestData
	{
		protected override string[] FolderName => new string[1] { "Parsers" };
		protected override string FileExtension => "*.*";
	}
}
