var sampleData = (function () {
    var returnObj = {};

    returnObj.allPets = [
        { petId: 1, petName: 'Kona', petDescription: 'Cutest Puppy Alive', petPhoto: 'img/Kona.jpg', active: 1 },
        { petId: 2, petName: 'Spike', petDescription: 'Loves Tom and Jerry', petPhoto: 'img/Spike.jpg', active: 1 },
        { petId: 3, petName: 'R2-D2', petDescription: 'Pal of C-3PO', petPhoto: 'img/R2-D2.jpg', active: 0 },
        { petId: 4, petName: 'Lassie', petDescription: 'Smart Cookie', petPhoto: 'img/Lassie.jpg', active: 0 },
        { petId: 5, petName: 'Fido', petDescription: '', petPhoto: 'img/Fido.jpg', active: 0 },
        { petId: 6, petName: 'Garfield', petDescription: '', petPhoto: 'img/Garfield.jpg', active: 1 },
        { petId: 7, petName: 'BB-8', petDescription: '', petPhoto: 'img/BB-8.jpg', active: 0 }
    ];

    returnObj.tasks = [
        { taskId: 1, taskTitle: 'Feed AM' },
        { taskId: 2, taskTitle: 'Walk AM' },
        { taskId: 3, Title: 'Fill Water AM' },
        { taskId: 4, Title: 'Feed PM' },
        { taskId: 5, Title: 'Walk PM' },
        { taskId: 6, Title: 'Fill Water PM', }
    ];

    return returnObj;
}());