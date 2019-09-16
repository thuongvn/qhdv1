
$(function () {
    var scrollEl = document.querySelector('#xonly .inner')
    var scr = new ScrollBooster({
        viewport: document.querySelector('#xonly .wrapper'),        
        bounce: false,
        textSelection: true,
        mode: 'x',
        onUpdate: function (data) {
            scrollEl.style.transform = 'translate(' + -data.position.x + 'px, ' + -data.position.y + 'px)'
        }
    })    
});
