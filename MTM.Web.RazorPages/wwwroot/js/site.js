// Write your Javascript code.

function showPetCreate() {

    $("#PetId").val('00000000-0000-0000-0000-000000000000');
    $("#PetActive").val(true);
    $("#PetCreatedDate").val('01/01/1901');
    $("#PetName").val('');
    $("#PetProfile").val('');
    $("#PhototUrl").val('');
    $("#dialog-create-update").dialog({
        height: 355,
        width: 500,
        modal: true
    });

};

function showPetEdit(pet) {

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

    $("#PetDeleteId").val(pet.Id);
    $("#PetDeleteName").val(pet.PetName);
    $("#PetNameDeleteMsg").text("Are you sure you want to delete " + pet.PetName + "?");
    $("#dialog-delete").dialog({
        height: 135,
        width: 500,
        modal: true
    });

};