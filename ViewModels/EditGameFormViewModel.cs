﻿using GameZone.Attributes;

namespace GameZone.ViewModels
{
	public class EditGameFormViewModel: GameFormViewModel
	{
        public int Id { get; set; }
        [AllowedExtension(FileSettings.AllowedExtensions), MaxFileSize(FileSettings.MaxFileSizeInBytes)]
        public string? CurrentCover { get; set; }
        public IFormFile? Cover { get; set; } = default!;

    }
}
