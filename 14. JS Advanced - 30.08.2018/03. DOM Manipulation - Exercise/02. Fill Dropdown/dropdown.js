function addItem() {
    let itemName = document.getElementById("newItemText").value;
    let itemValue = document.getElementById("newItemValue").value;
    let newOption = document.createElement('option');
    newOption.textContent = itemName;
    newOption.value = itemValue;

    document.getElementById("menu").appendChild(newOption);
    document.getElementById("newItemText").value = "";
    document.getElementById("newItemValue").value = "";
}
