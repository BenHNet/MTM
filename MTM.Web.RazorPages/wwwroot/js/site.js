// Write your Javascript code.

function showPet(pet) {

    $("#PetId").val(pet.Id);
    $("#PetActive").val(pet.Active);
    $("#PetCreatedDate").val(pet.CreatedDate);
    $("#PetName").val(pet.PetName);
    $("#PetProfile").val(pet.PetProfile);
    $("#PhototUrl").val(pet.PhotoUrl);
    $("#dialog-create-update").dialog({
        height: 335,
        width: 500,
        modal: true
    });

};

function showPetDelete(pet) {

    $("#PetId").val(pet.Id);
    $("#PetNameDeleteMsg").text("Are you sure you want to delete " + pet.PetName + "?");
    $("#dialog-delete").dialog({
        height: 135,
        width: 500,
        modal: true
    });

};