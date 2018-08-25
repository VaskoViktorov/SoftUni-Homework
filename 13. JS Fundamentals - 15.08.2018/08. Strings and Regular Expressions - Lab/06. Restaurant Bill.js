function restaurantBill(bill) {
    let purchased = [];
    let total=0;
    for (let i = 0; i <bill.length ; i+=2) {
        purchased.push(bill[i]);
        total+=Number(bill[i+1]);
    }

    console.log(`You purchased ${purchased.join(", ")} for a total sum of ${total}`);
}

restaurantBill(['Beer Zagorka', '2.65', 'Tripe soup', '7.80','Lasagna', '5.69']);