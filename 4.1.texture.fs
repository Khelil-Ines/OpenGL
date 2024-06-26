// #version 330 core
// out vec4 FragColor;

// in vec2 TexCoord;

// uniform sampler2D texture1;

// void main()
// {
//     FragColor = texture(texture1, TexCoord);
// }
#version 330 core
out vec4 FragColor;

in vec2 TexCoord;

// texture sampler
uniform sampler2D texture1;
uniform float alpha;

void main()
{
    vec4 texColor = texture(texture1, TexCoord);
    FragColor = vec4(texColor.rgb, texColor.a * alpha);
}
