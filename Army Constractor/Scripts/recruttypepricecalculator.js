function RecrutTypePriceCalcPlus(characteristic) {
    switch (characteristic) {
        case RecrutTypeAbsorb:
            var Absorb = $('#RecrutTypeAbsorb').val();
            if (Absorb == 5)
                alert("Это максимальное значение характеристики")
            else {
                Absorb++;
                $('#RecrutTypeAbsorb').val(Absorb);
            }
            break;
        case RecrutTypeArmorIgnore:
            var ArmorIgnore = $('#RecrutTypeArmorIgnore').val();
            if (ArmorIgnore == 5)
                alert("Это максимальное значение характеристики")
            else {
                ArmorIgnore++;
                $('#RecrutTypeArmorIgnore').val(ArmorIgnore);
            }
            break;
        case RecrutTypeAttBonus:
            var AttBonus = $('#RecrutTypeAttBonus').val();
            if (AttBonus == 10)
                alert("Это максимальное значение характеристики")
            else {
                AttBonus++;
                $('#RecrutTypeAttBonus').val(AttBonus);
            }
            break;
        case RecrutTypeBraveryBonus:
            var BraveryBonus = $('#RecrutTypeBraveryBonus').val();
            if (BraveryBonus == 5)
                alert("Это максимальное значение характеристики")
            else {
                BraveryBonus++;
                $('#RecrutTypeBraveryBonus').val(BraveryBonus);
            }
            break;
        case RecrutTypeDefBonus:
            var DefBonus = $('#RecrutTypeDefBonus').val();
            if (DefBonus == 10)
                alert("Это максимальное значение характеристики")
            else {
                DefBonus++;
                $('#RecrutTypeDefBonus').val(DefBonus);
            }
            break;
        case RecrutTypeRank:
            var Rank = $('#RecrutTypeRank').val();
            if (Rank == 5)
                alert("Это максимальное значение характеристики")
            else {
                Rank++;
                $('#RecrutTypeRank').val(Rank);
            }
            break;
        case RecrutTypeMove:
            var Move = $('#RecrutTypeMove').val();
            if (Move == 20)
                alert("Это максимальное значение характеристики")
            else {
                Move++;
                $('#RecrutTypeMove').val(Move);
            }
            break;
        default:
            alert('что-то пошло не так...');
    }
    var Price = RecrutTypeMovePrice() + RecrutTypeRankPrice() + RecrutTypeDefBonusPrice() + RecrutTypeBraveryBonusPrice()
        + RecrutTypeAttBonusPrice() + RecrutTypeArmorIgnorePrice() + RecrutTypeAbsorbPrice();
    $('#RecrutTypePrice').val(Price)
}

function RecrutTypePriceCalcMinus(characteristic) {
    switch (characteristic) {
        case RecrutTypeAbsorb:
            var Absorb = $('#RecrutTypeAbsorb').val();
            if (Absorb == 0)
                alert("Это минимальное значение характеристики")
            else {
                Absorb--;
                $('#RecrutTypeAbsorb').val(Absorb);
            }
            break;
        case RecrutTypeArmorIgnore:
            var ArmorIgnore = $('#RecrutTypeArmorIgnore').val();
            if (ArmorIgnore == 0)
                alert("Это минимальное значение характеристики")
            else {
                ArmorIgnore--;
                $('#RecrutTypeArmorIgnore').val(ArmorIgnore);
            }
            break;
        case RecrutTypeAttBonus:
            var AttBonus = $('#RecrutTypeAttBonus').val();
            if (AttBonus == 0)
                alert("Это минимальное значение характеристики")
            else {
                AttBonus--;
                $('#RecrutTypeAttBonus').val(AttBonus);
            }
            break;
        case RecrutTypeBraveryBonus:
            var BraveryBonus = $('#RecrutTypeBraveryBonus').val();
            if (BraveryBonus == 0)
                alert("Это минимальное значение характеристики")
            else {
                BraveryBonus--;
                $('#RecrutTypeBraveryBonus').val(BraveryBonus);
            }
            break;
        case RecrutTypeDefBonus:
            var DefBonus = $('#RecrutTypeDefBonus').val();
            if (DefBonus == 0)
                alert("Это минимальное значение характеристики")
            else {
                DefBonus--;
                $('#RecrutTypeDefBonus').val(DefBonus);
            }
            break;
        case RecrutTypeRank:
            var Rank = $('#RecrutTypeRank').val();
            if (Rank == 1)
                alert("Это минимальное значение характеристики")
            else {
                Rank--;
                $('#RecrutTypeRank').val(Rank);
            }
            break;
        case RecrutTypeMove:
            var Move = $('#RecrutTypeMove').val();
            if (Move == 4)
                alert("Это минимальное значение характеристики")
            else {
                Move--;
                $('#RecrutTypeMove').val(Move);
            }
            break;
        default:
            alert('что-то пошло не так...');
    }
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