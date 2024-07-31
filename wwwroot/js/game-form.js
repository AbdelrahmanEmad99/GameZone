$(document).ready(function () {
    $('#Cover').on('change', function () {
        if (this.files && this.files[0]) {
            var objectUrl = URL.createObjectURL(this.files[0]);
            var $coverPreview = $('.cover-preview');

            $coverPreview.removeClass('d-none').attr('src', objectUrl);

            // Revoke the object URL after the image is loaded to release memory
            $coverPreview.on('load', function () {
                URL.revokeObjectURL(objectUrl);
            });
        }
    });
});