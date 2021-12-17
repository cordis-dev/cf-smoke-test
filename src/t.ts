// should not report trailing-comma
// should report trailing-whitespace
@NgModule({ 
  exports: [ RouterModule ],
  imports: [ RouterModule.forRoot(routes, { enableTracing: true }) ],
})
export class AppModule { }
