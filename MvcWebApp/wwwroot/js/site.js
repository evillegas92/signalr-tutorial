// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

async function submitBid(auctionItemId) {
    console.log('placing bid on item ', auctionItemId);
    const bidAmount = document.getElementById(auctionItemId + "-bidInput").value;
    const response = await fetch("/auctionitem/bid", {
        method: "POST",
        headers: {
            'Accept': 'application/json',
            'Content-type': 'application/json',
        },
        body: JSON.stringify({
            auctionItemId: auctionItemId,
            bidAmount: bidAmount
        })
    });
    if (!response || !response.ok) {
        alert("Error");
        return;
    }
    location.reload();
}