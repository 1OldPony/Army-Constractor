function shieldPriceCalcPlus() {
    var shieldDef = $('#ShieldDefBonus').val();

    if (shieldDef === 5)
        alert("Это максимальное значение характеристики")
    else {
        shieldDef++;
        $('#ShieldDefBonus').val(shieldDef);
        $('#ShieldPrice').val(shieldDef * 5)
    }
}
function shieldPriceCalcMinus() {
    var shieldDef = $('#ShieldDefBonus').val();
    
    if (shieldDef === 1)
        alert("Это минимальное значение характеристики")
    else {
        shieldDef--;
        $('#ShieldDefBonus').val(shieldDef);
        $('#ShieldPrice').val(shieldDef * 5)
    }
}