window.onload = function RecrutTypePriceCalc() {
    var Price = RecrutTypeMovePrice() + RecrutTypeRankPrice() + RecrutTypeDefBonusPrice() + RecrutTypeBraveryBonusPrice()
        + RecrutTypeAttBonusPrice() + RecrutTypeArmorIgnorePrice() + RecrutTypeAbsorbPrice();
    $('#RecrutTypePrice').val(Price)
}
function RecrutTypeMovePrice() {
    var RecrutTypeMove = $('#RecrutTypeMove').val();
    return RecrutTypeMove * 2;
}
function RecrutTypeRankPrice() {
    var RecrutTypeRank = $('#RecrutTypeRank').val();
    return RecrutTypeRank * 10;
}
function RecrutTypeDefBonusPrice() {
    var RecrutTypeDefBonus = $('#RecrutTypeDefBonus').val();
    return RecrutTypeDefBonus * 5;
}
function RecrutTypeBraveryBonusPrice() {
    var RecrutTypeBraveryBonus = $('#RecrutTypeBraveryBonus').val();
    return RecrutTypeBraveryBonus * 5;
}
function RecrutTypeAttBonusPrice() {
    var RecrutTypeAttBonus = $('#RecrutTypeAttBonus').val();
    return RecrutTypeAttBonus * 5;
}
function RecrutTypeArmorIgnorePrice() {
    var RecrutTypeArmorIgnore = $('#RecrutTypeArmorIgnore').val();
    return RecrutTypeArmorIgnore * 5;
}
function RecrutTypeAbsorbPrice() {
    var RecrutTypeAbsorb = $('#RecrutTypeAbsorb').val();
    return RecrutTypeAbsorb * 5;
}
