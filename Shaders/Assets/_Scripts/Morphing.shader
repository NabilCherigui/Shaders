﻿  Shader "Size/Morphing" {
    Properties {
      _MainTex ("Texture", 2D) = "white" {}
      _Amount ("Girth Amount", Range(-0.5,0.5)) = 0.5
    }
    SubShader {
      Tags { "RenderType" = "Opaque" }
      CGPROGRAM
      //dun is -0.16
      //dik is 0.5
      #pragma surface surf Lambert vertex:vert
      
      struct Input {
          float2 uv_MainTex;
      };
      
      float _Amount;
      
      void vert (inout appdata_full v) {
          v.vertex.xyz += v.normal * _Amount;
      }
      
      sampler2D _MainTex;
      
      void surf (Input IN, inout SurfaceOutput o) {
          o.Albedo = tex2D (_MainTex, IN.uv_MainTex).rgb;
      }
      ENDCG
    } 
    Fallback "Diffuse"
  }