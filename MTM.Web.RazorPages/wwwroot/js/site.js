// Write your Javascript code.

function showPet(pet) {

    $("#PetName").val(pet.PetName);
    $("#PetProfile").val(pet.PetProfile);
    $("#PhotoUrl").val(pet.PhotoUrl);
    $("#dialog-create-update").dialog({
        height: 400,
        width: 500,
        modal: true
    });

};

function showPetDelete(pet) {

    $("#PetNameDeleteMsg").text("Are you sure you want to delete " + pet.PetName + "?");
    $("#dialog-delete").dialog({
        height: 150,
        width: 500,
        modal: true
    });

};