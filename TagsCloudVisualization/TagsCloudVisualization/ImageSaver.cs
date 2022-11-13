﻿using System.Drawing;
using System.Drawing.Imaging;

namespace TagsCloudVisualization;

public class ImageSaver
{
	public ImageSaver(string directory, ImageFormat format)
	{
		Format = format;
		Directory = directory;

		System.IO.Directory.CreateDirectory(directory);
	}

	public ImageFormat Format { get; }
	public string Directory { get; }

	public string Save(Image image, string name)
	{
		var path = $"{Directory}\\{name}.{Format.ToString().ToLower()}";
		image.Save(path, Format);
		return path;
	}
}