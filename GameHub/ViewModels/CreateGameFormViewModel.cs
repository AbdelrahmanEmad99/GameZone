
using GameZone.Attributes;
using System.Runtime.CompilerServices;

namespace GameZone.ViewModels
{
	public class CreateGameFormViewModel: GameFormViewModel
	{
		 

		//validate extension and size
		[AllowedExtension(FileSettings.AllowedExtensions)]
		[MaxFileSize(FileSettings.MaxFileSizeInBytes)]
 		public IFormFile Cover { get; set; } = default!;

	}
}
