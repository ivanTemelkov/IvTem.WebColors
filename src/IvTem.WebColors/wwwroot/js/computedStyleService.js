export function getComputedColor(colorString) {

    const element = document.createElement('span');
    element.style.color = '';           // start with no color
    element.style.display = 'none';
    document.body.appendChild(element);

    // Attempt to assign the color. For invalid values, the style stays "".
    element.style.color = colorString;

    const isValid = element.style.color !== '';
    let computedColor = '';
    if (isValid) {
        computedColor = getComputedStyle(element).color; // "rgb(...)" or "rgba(...)"
    }

    element.remove();
    return computedColor;               // "" means "not a valid color"
}
