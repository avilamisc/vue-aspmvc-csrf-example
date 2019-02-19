<template>
  <div id="app">
    <button @click="submit_without_token">Submit without token in request header</button>
    <button @click="submit_with_token">Submit with token in request header</button>
    <div class="result">
      <p v-if="result != ''"><b>Result: </b>{{result}}</p>
      <p v-if="req_token != ''"><b>Token: </b>{{req_token}}</p>
    </div>
  </div>
</template>

<script>
/* eslint-disable */
export default {
  name: 'app',
  data(){
    return{
      submit_url: '/home/submit',
      result: '',
      req_token: ''
    }
  },
  methods:{
    submit_with_token(){
      this.clear()

      const self = this
      this.req_token = document.getElementById('__RequestVerificationToken').value
      this.axios({
          method: 'post',
          url: self.submit_url,
          headers: {'RequestVerificationToken': self.req_token}
        }).then((response) => {
          self.result = response.data
        }).catch(error => {
          self.result = 'Error Occurred!'
      })
    },
    submit_without_token(){
      this.clear()

      const self = this
      this.axios.post(this.submit_url).then((response) => {
        self.result = response.data
      }).catch(error => {
          self.result = 'Error Occurred!'
      })
    },
    clear(){
      this.req_token = ''
      this.result = ''
    }
  }
}
</script>

<style>
#app {
  font-family: "Times New Roman", Times, serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
button {
  background-color: #e7e7e7; 
  border: 1px solid #eee;
  color: #555555;
  padding: 15px 32px;
  margin: 10px auto;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  width: 380px;
}
button:hover {
  background-color: #555555;
  color: #e7e7e7;
}
.result {
  border: 1px solid #e7e7e7;
  padding: 10px;
  margin: 10px auto;
  width: 740px;
  text-align: left;
}
.result p{
  overflow: auto;
  padding: 10px 20px;
}
</style>
