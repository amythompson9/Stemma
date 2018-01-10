//Instantiating dialog with Filestack
var client = filestack.init("ADNPuOy4rSV6VFpz7hYHHz");
var imageSrc = '';
//var transformURL = "https://cdn.filestack.com/imageSrc=file:";
//Filestack API method 'pick()' that opens the file picker
function upload() {
    client.pick({
        accept: ['image/*', '.pdf', 'video/mp4', '.docx'],
        fromSources: ["local_file_system", "imagesearch", "facebook", "instagram", 'googledrive', "url", "gmail", "clouddrive", "webcam", "video", "audio"],
        lang: 'en',
        maxSize: 20000000,
        maxFiles: 5,
        minFiles: 1,
        imageMax: [400, 400],
        imageMin: [400, 400],
        startUploadingWhenMaxFilesReached: true,
        videoResolution: '1280x720',
        transformations: { parameter: true },
        transformations: { rotate: true },
        transformations: { crop: true },

    }).then(function (result) {
        console.log(JSON.stringify(result.filesUploaded));
        imageSrc = result.filesUploaded[0].url;
        console.log(imageSrc);
        console.log('before');
        document.getElementById('UploadMedia').value = imageSrc;
        console.log('Done')
        show();
    });
};
function show() {
    document.getElementById('itemImg').innerHTML += '<div class="image-container col-md-4">' + '<img class="img-responsive image-container" src="' + imageSrc + '"/></div>'
}