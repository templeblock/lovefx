#version 330

//uniform sampler2D diff_tex;
in vec2 uv;
in vec3 nor;

out vec4 frag;

void main()
{
    frag = vec4(1);

    vec3 n = nor * 0.5 + vec3(.5);
    frag = vec4(n, 1.0);

    // frag = vec4(uv, 0.0, 1.0);

    //float k = gl_FragCoord.z;
    //frag = vec4(k, k, k, 1);
}