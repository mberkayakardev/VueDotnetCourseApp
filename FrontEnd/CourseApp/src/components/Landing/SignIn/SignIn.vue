<template>
    <div id="LoginFormDiv" class="mx-auto align-middle">
  <Form :validation-schema="FormSchema">
  
    <h1 class="h3 mb-3 fw-normal text-center">Kurs Uygulaması</h1>
    <div class="form-floating mb-3 p-1">
      <Field name="UserName" v-slot="{field, errors, errorMessage}">
        <input type="text" v-bind="field" class="form-control"  :class="{'is-invalid':errors.length !== 0  }" id="floatingInput" placeholder="Kullanıcı Adı"  />
        <div class="invalid-feedback" v-if="errors.length !== 0" c>
          {{ errorMessage }}
        </div>
      </Field>
    </div>

    <div class="form-floating mb-3 p-1">
      <Field name="Password" v-slot="{field, errors, errorMessage}">
        <input type="password" v-bind="field" class="form-control" :class="{'is-invalid':errors.length !== 0  }" id="floatingPassword" placeholder="Şifre">
        <div class="invalid-feedback" v-if="errors.length !== 0">
          {{ errorMessage }}
        </div>
      </Field>
    </div> 

    <div class="checkbox mb-3 ml-2">
        <input type="checkbox" value="remember-me"> Beni Hatırla
    </div>
    <button class="w-100 btn btn-lg btn-primary text-light " type="submit">Giriş Yap</button>
    <br>
    <br>
    <div>
      <span id="KayitOlGirisYapLink" class="text-information" @click="isLoginScreen != isLoginScreen" > Kayıt Ol </span>
    </div>
  </Form>
</div>

</template>


<script setup>

import {Field, Form} from 'vee-validate' /// Form ve Field i kullanacağız (from submit olunca direk values lere erişebiliyoruz )
import * as yup from 'yup'

const FormSchema = yup.object({
  UserName:yup.string().required("Kullanıcı Adı Boş Geçilemez"),
  Password:yup.string().required("Password Boş geçilemez.")
})

alert('SA')

</script>




<style>


#LoginFormDiv
{
    max-width:700px;
    margin-top : 10%;
}

#KayitOlGirisYapLink{
  cursor: pointer;
  color:  rgb(var(--v-theme-primary)) !important;
}
</style>



