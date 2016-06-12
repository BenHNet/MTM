var utilities = (function () {
    var returnObj = {};
    
    returnObj.addContact = function () {

        navigator.contacts.pickContact(function (contact) {
            console.log('The following contact has been selected:' + JSON.stringify(contact));
        }, function (err) {
            console.log('Error: ' + err);
        });
    };
    
    returnObj.addPhoto = function () {

        navigator.camera.getPicture(onPhotoSuccess, onPhotoFail, {
            quality: 50,
            destinationType: Camera.DestinationType.FILE_URI
        });
    };

    function onPhotoSuccess(imageURI) {

        var image = document.getElementById('myImage');
        image.src = imageURI;
    }

    function onPhotoFail(message) {

        alert('Failed because: ' + message);
    }

    return returnObj;
}());