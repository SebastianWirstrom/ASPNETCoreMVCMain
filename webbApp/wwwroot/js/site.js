document.addEventListener('DOMContentLoaded', function () {
    handleProfileImageUpload()
})

function handleProfileImageUpload() {
    try {
        let uploadFile = document.getElementById('uploadFile')

        if (uploadFile != undefined) {
            uploadFile.addEventListener('change', function () {
                if (this.files.length > 0) {
                    this.form.submit()
                }
            })
        }
    }
    catch (error) {
        console.error('Error in handleProfileImageUpload:', error);
    }
}