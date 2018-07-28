window.onload = function UnitPriceCalc() {
    var Mount = $('#MountPrice').val();
    var Shield = $('#ShieldPrice').val();
    var SecondWeapon = $('#SecondWeaponPrice').val();
    var RangeWeapon = $('#RangeWeaponPrice').val();
    var MeleeWeapon = $('#MeleeWeaponPrice').val();
    var Armor = $('#ArmorPrice').val();
    var RecrutType = $('#RecrutTypePrice').val();
    var Combatants = $('#NumberOfCombatants').val();

    var sum = Mount*1 + Shield*1 + SecondWeapon*1 + RangeWeapon*1
        + MeleeWeapon*1 + Armor*1 + RecrutType*1;
    var price = sum * Combatants
    $('#UnitPrice').val(price)
}